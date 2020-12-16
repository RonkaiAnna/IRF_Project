using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Beadandó
{

    public partial class Adatbevitel : UserControl
    {
        adatbazisEntities context = new adatbazisEntities();
        public Adatbevitel()
        {
            InitializeComponent();
            //Tábla betöltése a datagridview-ba
            context.Jelentkezok.Load();
            jelentkezokBindingSource.DataSource = context.Jelentkezok.Local;
        }

        //Törlés gomb eseménye
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            mentesesfrissites();
        }
        
        //Mentésgomb eseménye
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mentesesfrissites();
        }

        private void hozzaadasgomb_Click(object sender, EventArgs e)
        {
            /*A következő kódrészlet kikényszeríti, hogy a két textboxot ne hagyjuk üresen,
            mert az adatbázisba nem lehet üres cellákat hagyni a megadott oszlopokban.
            Amennyiben a kitöltés megfelelő, az új elemet hozzáadjuk az adatbázishoz*/
            errorProvider1.Clear();
            if (textBox1.Text!="" && textBox2.Text!="")
            {
                jelentkezohozzaadas();
                mentesesfrissites();
            }
            else
            {
                if (textBox1.Text=="")
                {
                    errorProvider1.SetError(textBox1, "A név cím nem lehet üres");
                }
                if (textBox2.Text=="")
                {
                    errorProvider1.SetError(textBox2, "Az email cím nem lehet üres!");
                }  
            }
        }

        //Jelentkező hozzáadása
        private void jelentkezohozzaadas()
        {
            Jelentkezok jelentkezo = new Jelentkezok();
            jelentkezo.Név = textBox1.Text;
            jelentkezo.Email_cím = textBox2.Text;
            jelentkezokBindingSource.Add(jelentkezo);
        }

        //Mentés és frissítés funkció
        private void mentesesfrissites()
        {
            jelentkezokBindingSource.EndEdit();
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            jelentkezokDataGridView.Refresh();
        }
    }
}
