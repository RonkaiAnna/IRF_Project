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
        public Form1()
        {
            InitializeComponent();
        }

        //Adatbevitelt tartalmazó usercontrol betöltése a panelra
        private void adatbevitelgomb_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl adatbevitel = new Adatbevitel();
            panel1.Controls.Add(adatbevitel);
            adatbevitel.Dock = DockStyle.Fill;
        }

        //Sorsoló felület betöltése a panelra
        private void sorsolasgomb_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl sorsolas = new Sorsolás();
            panel1.Controls.Add(sorsolas);
            sorsolas.Dock = DockStyle.Fill;
        }
    }
}
