using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Beadandó
{
    public partial class Sorsolás : UserControl
    {
        adatbazisEntities context = new adatbazisEntities();
        Random rnd = new Random();
        public Sorsolás()
        {
            InitializeComponent();
            Sorsoltakbetoltes();
        }
        private void Sorsoltakbetoltes()
        {
            var mind = from j in context.Sorsoltak
                       select j;
            sorsoltakBindingSource.DataSource = mind.ToList();
        }

        private void sorsologomb_Click(object sender, EventArgs e)
        {
            Sorsolas();
        }
        
        void Sorsolas()
        {
            var min = (from x in context.Jelentkezok
                       select x.Id).Min();
            var max = (from x in context.Jelentkezok
                       select x.Id).Max();
            var összesj = (from j in context.Jelentkezok
                           select j).Count();
            var összess = (from s in context.Sorsoltak
                           select s).Count();
            //MessageBox.Show(min.ToString());
            //MessageBox.Show(max.ToString());
            //MessageBox.Show(összess.ToString());
            //MessageBox.Show(összesj.ToString());
            bool egyezik;
            if (összesj == összess)
            {
                egyezik = false;
                MessageBox.Show("Minden jelentkezőt kisorsoltak már");
            }
            else
            {
                egyezik = true;
            }
            while (egyezik == true)
            {
                int kit = rnd.Next(min, max + 1);
                //MessageBox.Show(kit.ToString());
                var sorsolt = (from x in context.Sorsoltak
                         where x.SorsotlId == kit
                         select x).Count();
                //MessageBox.Show(sorsolt.ToString());
                if (sorsolt == 0)
                {
                    egyezik = false;
                    Sorsoltak kisorsolt = new Sorsoltak();


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
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Hiba a mentéskor: " + ex.Message);
                    }
                    var lekerdezes = from x in context.Sorsoltak
                                     select x;
                    sorsoltakBindingSource.DataSource = lekerdezes.ToList();

                }
            }



        }

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

        private void deletegomb_Click(object sender, EventArgs e)
        {
            var delete = from x in context.Sorsoltak
                         select x;
            //context.Sorsoltak.Remove(delete);
            context.Sorsoltak.RemoveRange(delete);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hiba a mentéskor: " + ex.Message);
            }
            var lekerdezes = from x in context.Sorsoltak
                             select x;
            sorsoltakBindingSource.DataSource = lekerdezes.ToList();
        }
    }
}
