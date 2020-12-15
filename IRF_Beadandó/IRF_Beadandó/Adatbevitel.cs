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
            context.Jelentkezok.Load();
            jelentkezokBindingSource.DataSource = context.Jelentkezok.Local;
        }


        private void jelentkezokBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
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
