using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using PointOfSale.Forms;
using PointOfSale.Classes;



namespace PointOfSale
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.lblUserFullName.Text = Declaration.userFullName;
        }

        private void OpenChildForm(Form cForm, object btnSender)
        {
            if (activeForm!= null)
            {
                activeForm.Close();
            }
            activeForm = cForm;
            ActiveButton(btnSender);
            cForm.TopLevel = false;
            cForm.FormBorderStyle = FormBorderStyle.None;
            cForm.Dock=DockStyle.Fill;
            pnlMainForm.Controls.Add(cForm);
            pnlMainForm.Tag= cForm;
            cForm.BringToFront();
            cForm.Show();
        }
        private Color SelectTheme()
        {
            if (currentButton.Text == "Point Of Sale")
                return Color.SlateGray;
            else if (currentButton.Text == "Setup")
                return Color.   LightCoral;
            else if (currentButton.Text == "Reporting")
                return Color.SteelBlue;
            else if (currentButton.Text == "Options")
                return Color.SandyBrown;
            else
                return Color.Gray;

        }

        private void ActiveButton(object sender)
        {
            if (sender != null)
            {

                if (currentButton != (Button)sender)
                {
                    unSelectButton();
                    currentButton = (Button)sender;
                    Color color = SelectTheme();
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Tohoma", 11F, FontStyle.Bold);
                    pnlTitle.BackColor= color;
                    lblTitle.Text=currentButton.Text;
                }
            }
        }

        private void unSelectButton()
        {
            foreach (Control ctr in pnlMenu.Controls)
            {
                if (ctr.GetType() == typeof(Button))
                {
                    ctr.BackColor = Color.Gray;
                    ctr.ForeColor = Color.White;
                    ctr.Font = new Font("Tohoma", 8F, FontStyle.Regular);
                }
            }
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainPointOfSale(),  sender); 

        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainSetUp(), sender);
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainReports(), sender);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainOptions(), sender);
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/aml-rizk-b5547530a");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlMainForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
