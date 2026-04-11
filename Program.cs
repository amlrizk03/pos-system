using PointOfSale.Classes;
using PointOfSale.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            adoCalss.setConnection();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin frmLogIn = new FormLogin();
            if (frmLogIn.ShowDialog() == DialogResult.OK)
            {

                Application.EnableVisualStyles();    
                Application.Run(new MainForm());
            }
        }
    }
}
