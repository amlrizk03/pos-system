using PointOfSale.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PointOfSale.Forms
{
    public partial class MainSetUp : Form
    {
        public MainSetUp()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FormUsers form = new FormUsers();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCategories form = new FormCategories();
            form.ShowDialog();
        }



        private void btnItems_Click(object sender, EventArgs e)
        {
            FormItmes form = new FormItmes();
            form.ShowDialog();
        }
    }
}
    
