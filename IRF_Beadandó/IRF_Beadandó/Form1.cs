﻿using System;
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
        adatbazisEntities context = new adatbazisEntities();
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

            }
        }

        private void sorsologomb_Click(object sender, EventArgs e)
        {
            Sorsolas();
        }
        void Sorsolas()
        {
            //List<Nyertes> nyert = (from j in context.Jelenetkezok
            //             where j.Id == 1
            //             select new Nyertes(j)).ToList();
            // kisorsoltakdgw.DataSource = nyert;
            var nyert = from j in context.Jelenetkezok
                        where j.Id == 1
                        select j;
            kisorsoltakdgw.DataSource = nyert.ToList();

        }
    }
}
