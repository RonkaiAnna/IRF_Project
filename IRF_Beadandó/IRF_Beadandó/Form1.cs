using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        adatbazisEntities2 context = new adatbazisEntities2();
        Random rnd = new Random();
        List<Jelentkezok> nyerő = new List<Jelentkezok>();
        public Form1()
        {
            InitializeComponent();
            context.Sorsoltak.Load();
            sorsoltakBindingSource.DataSource = context.Sorsoltak.Local;
            
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
                foreach (var j in nyerő)
                {
                    sw.Write(j.Név);
                    sw.Write(";");
                    sw.Write(j.Email_cím);
                    sw.WriteLine();
                    
                }
                
            }
        }

        private void sorsologomb_Click(object sender, EventArgs e)
        {
            //Sorsolas();
        }
        int kit;
        /*void Sorsolas()
        {
            
            var összes = (from j in context.Jelentkezok
                          select j).Count();
            ID probléma
            var első = (from j in context.Jelentkezok
                        select j.Id).First();
            var utolsó = (from j in context.Jelentkezok
                          select j.Id).Last();
            MessageBox.Show(első.ToString());
            int kit = rnd.Next(első, utolsó);
            for (int i = 0; i < 2; i++)
            {
                kit = rnd.Next(1, összes + 1);
                List<Jelentkezok> nyert = (from j in context.Jelentkezok
                                           where j.Id == kit
                                           select j).ToList();
                nyerő = nyert;
            }
               
            
                
            
            kisorsoltakdgw.DataSource = nyerő;

            var nyert = from j in context.Jelentkezok
                                       where j.Id == kit
                                       select j;
            nyerő.Add(nyert);



            //var nyert = from j in context.Jelentkezok
            //            where j.Id == kit
            //            select j;
            //kisorsoltakdgw.DataSource = nyert.ToList();

        }*/
    }
}
