using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Beadandó
{
    public partial class Sorsolás : UserControl
    {
        adatbazisEntities context = new adatbazisEntities();
        Random rnd = new Random();
        Regex regex = new Regex(@"(^[0-9]*$)");

        public Sorsolás()
        {
            InitializeComponent();
            Sorsoltakbetoltes();
            /*Usercontrol betöltsekor leellenőrzi, hogy a Sorsoltak tábla tartalmaz-e adatokat,
            amennyiben már tartalmaz, akkor a sorsolás gombot letiltja.
            Ennek oka, hogy a sorsolás funkció végtelen ciklusba tud futni, ha több nyertes akarunk sorsolni mint ahány résztvevő van.
            A végtelen ciklus a későbbiekben ki van védve és messagebox, figyelmeztet, hogy már nem lehet tovább sorsolni.*/
            int összess = összessorsoltcount();
            if (összess != 0)
            {
                sorsologomb.Enabled = false;
            }
        }

        //Sorsolás gomb eseménye
        private void sorsologomb_Click(object sender, EventArgs e)
        {
            int összesj = összesjelentkezocount();
            //MessageBox.Show(összesj.ToString());
            //A textbox értékeinek lekezelése
            //Textbox üres marad
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Nyertesek száma nem lehet üres!");
            }
            //Textboxban csak számok vannak
            else if (regex.IsMatch(textBox1.Text))
            {
                //a megadott szám nagyobb-e mint az összes jelentkező
                if (Convert.ToInt32(textBox1.Text) > összesj)
                {
                    errorProvider1.SetError(textBox1, "A jelentkezők száma: " + összesj.ToString() + "! Ennél több nyertest nem lehet sorsolni");
                }
                else
                {
                    //Textbox megfelelően kitöltve
                    // Sorsolás lefutattása annyiszor, ahány nyertes megadtak
                    errorProvider1.Clear();
                    for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                    {
                        Sorsolas();
                    }
                    //Sorsolás után gomb letiltás, hogy újabb sorsolás inditással ne kerüljön a program végtelen ciklusba
                    sorsologomb.Enabled = false;
                }
            }
            //Maradék esett: kitöltve a textbox, de nem csak számokkal hanem más karakterekkel is
            else
            {
                errorProvider1.SetError(textBox1, "Csak számokat fogad el!");
            }
        }

        //Sorsolás funkció
        void Sorsolas()
        {
            //Melyik a legkisebb ID a jelentkezőknél
            var min = (from x in context.Jelentkezok
                       select x.Id).Min();
            //Melyik a legnagyobb ID a jelentkezőknél
            var max = (from x in context.Jelentkezok
                       select x.Id).Max();
            //Összesen hány jelentkező van
            var összesj = összesjelentkezocount();
            //Összesen hány nyertes/sorsolt van
            var összess = összessorsoltcount();
            //MessageBox.Show(min.ToString());
            //MessageBox.Show(max.ToString());
            //MessageBox.Show(összess.ToString());
            //MessageBox.Show(összesj.ToString());
            //Végtelen ciklus kikerülése érdekében létrehozott változó
            bool egyezik;
            /*Amennyiben a jelentkezők és nyertesek azonos létszámúak,
            tehát minden jelentkező ki lett már sorsolva,
            ez a változó hamis értéket vesz fel,
            így nem engedi elkezdeni a while ciklust,
            mert nincs értelme tovább keresni sorsoltat,
            mert nem lehet már új embert sorolni.
            Azzal, hogy a sorsolást csak üres tábla mellett lehet elinditani,
            és a texboxba csak a jelentkezőknél kisebb számot szabad írni,
            gyakorlatilag helyes futás mellett a kód sosem lép be ebbe az if-ágba, csak az else-be.
            Ez az if a fejlesztés egy korábbi szakaszában készült még, amikor ezek a hibák még nem voltak lekezelve*/
            if (összesj == összess)
            {
                egyezik = false;
                MessageBox.Show("Minden jelentkezőt kisorsoltak már");
            }
            else
            {
                egyezik = true;
            }
            //Addig fut a while amíg olyan számot nem generálunk, amely még nem szerepelt a SorsoltId-k között
            while (egyezik == true)
            {
                //Random szám generálás, a jelentkezők max és min id-ja alapján
                int kit = rnd.Next(min, max + 1);
                //MessageBox.Show(kit.ToString());
                /*Létezik-e a random számnak megfelelő Id a jelentkezőkben,
                erre azért van szükség mert a jelentkezőkből lehet törölni, így azok az Id-k kiesnek*/
                var letezik = (from x in context.Jelentkezok
                              where x.Id == kit
                              select x).Count();
                //MessageBox.Show(letezik.ToString());
                //Ha létezik ilyen Id-ju jelentkező, megnézzük, hogy sorsoltuk-e már korábban, benne van már-e a sorsoltak táblában
                if (letezik != 0)
                {
                    var sorsolt = (from x in context.Sorsoltak
                                   where x.SorsotlId == kit
                                   select x).Count();
                    //MessageBox.Show(sorsolt.ToString());
                    //Ha a sorsolt szám még nincs a táblában akkor a sorsolás megtörténik és kilépünk a while cilusból
                    if (sorsolt == 0)
                    {
                        egyezik = false;
                        Sorsoltak kisorsolt = new Sorsoltak();

                        //A kisorsolt jelentkező adatait átadjuk a sorsoltak táblának, ezzel egy ú kisorsolt jön létre
                        var nyertes = from x in context.Jelentkezok
                                      where x.Id == kit
                                      select x;
                        foreach (var x in nyertes)
                        {
                            kisorsolt.SorsoltNév = x.Név;
                            kisorsolt.SorsoltEmail_cím = x.Email_cím;
                            kisorsolt.SorsotlId = x.Id;
                        }
                        context.Sorsoltak.Add(kisorsolt);
                        //mentjük a változtatásokat, és frissítjük a datagridviewt
                        mentesesfrissites();
                    }
                }
            }
        }

        //Fájlba kimentés gomb, így a nyerteseket a fájl alapján könnyű értesíteni
        private void mentesgomb_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var x in context.Sorsoltak)
                {
                    sw.Write(x.SorsoltNév);
                    sw.Write(";");
                    sw.Write(x.SorsoltEmail_cím);
                    sw.WriteLine();
                }
            }
        }

        //Tábla adatainak törlése és sorsológomb tiltásának feloldása
        private void deletegomb_Click(object sender, EventArgs e)
        {
            var delete = from x in context.Sorsoltak
                         select x;
            //context.Sorsoltak.Remove(delete);
            context.Sorsoltak.RemoveRange(delete);
            mentesesfrissites();
            sorsologomb.Enabled = true;
        }

        //Adatok betöltése a datagridview-ba
        private void Sorsoltakbetoltes()
        {
            var mind = from j in context.Sorsoltak
                       select j;
            sorsoltakBindingSource.DataSource = mind.ToList();
        }

        //Vátoztatások mentése és datagridview frissítése
        private void mentesesfrissites()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a mentéskor: " + ex.Message);
            }
            Sorsoltakbetoltes();
        }

        //Összes sorsolt megszámolása
        private int összessorsoltcount()
        {
            return (from s in context.Sorsoltak
                    select s).Count();
        }

        //Összes jelenetkező megszámolása
        private int összesjelentkezocount()
        {
            return (from j in context.Jelentkezok
                    select j).Count();
        }
    }
}
