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
    public partial class Form1 : Form
    {
        adatbazisEntities1 context = new adatbazisEntities1();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            
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
                foreach (var j in context.Jelentkezok)
                {
                    sw.Write(j.Id);
                    sw.Write(";");
                    sw.Write(j.Név);
                    sw.Write(";");
                    sw.Write(j.Email_cím);
                    sw.WriteLine();
                }
                //List<Nyertes> nyert = (from j in context.Jelentkezok
                //                       where j.Id == 1
                //                       select new Nyertes(j)).ToList();
                //foreach (var j in nyert)
                //{
                //    sw.Write(j.Név);
                //    sw.Write(";");
                //    sw.Write(j.Email_cím);
                //    sw.WriteLine();
                //}
            }
        }

        private void sorsologomb_Click(object sender, EventArgs e)
        {
            Sorsolas();
        }
        
        void Sorsolas()
        {
            //List<Nyertes> nyert = (from j in context.Jelentkezok
            //                       where j.Id == 1
            //                       select new Nyertes(j)).ToList();
            //kisorsoltakdgw.DataSource = nyert;
            var összes = (from j in context.Jelentkezok
                          select j).Count();
            //var első = (from j in context.Jelentkezok
            //            select j.Id).First();
            //var utolsó = (from j in context.Jelentkezok
            //              select j.Id).Last();
            //MessageBox.Show(első.ToString());
            //int kit = rnd.Next(első, utolsó);
            int kit = rnd.Next(1, összes + 1);
            var nyert = from j in context.Jelentkezok
                        where j.Id == kit
                        select j;
            kisorsoltakdgw.DataSource = nyert.ToList();

        }
    }
}
