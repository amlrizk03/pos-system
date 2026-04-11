using PointOfSale.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private SqlCommand cmd;
        private SqlDataReader dr;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            txtUserName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Enter your user name ");
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter your password ");
                return;
            }
            logIn();
        }
        private void logIn()
        {
            string selectSql = " SELECT * From Users where userName = @userName and password = @password";
            cmd = new SqlCommand(selectSql, adoCalss.sqlCn);
            dr = null;
            cmd.Parameters.Add(new SqlParameter("@userName", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar));
            cmd.Parameters["@password"].Value = txtPassword.Text;
            cmd.Parameters["@userName"].Value = txtUserName.Text;
            try
            {
               if(adoCalss.sqlCn.State!=ConnectionState.Open) adoCalss.sqlCn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Declaration.userId= int.Parse(dr["id"].ToString());
                        Declaration.userFullName = dr["fullName"].ToString();
                    }
                    this.DialogResult=DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Login Faild! Please try again");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCalss.sqlCn.Close();
            }
        }
    }
}
