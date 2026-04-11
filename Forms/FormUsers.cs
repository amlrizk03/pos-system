using PointOfSale.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PointOfSale.Forms
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private SqlDataAdapter _adapter;
        private DataTable dataTable;
        private DataRow row;
        private int index;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            _adapter = new SqlDataAdapter("select * From Users", adoCalss.sqlCn);
            dataTable = new DataTable();
            _adapter.Fill(dataTable);
            index = 0;
            loadData(0);
        }

        private void loadDataWithIndex(int _index)
        {
            index = _index;
            if (dataTable.Rows.Count > 0 && _index >= 0 && _index <= dataTable.Rows.Count - 1)
            {
                txtUserName.Text = dataTable.Rows[_index]["userName"].ToString();
                txtPassword.Text = dataTable.Rows[_index]["password"].ToString();
                txtFullName.Text = dataTable.Rows[_index]["fullname"].ToString();
                txtJobDes.Text = dataTable.Rows[_index]["jobDes"].ToString();
                txtPhone1.Text = dataTable.Rows[_index]["phone"].ToString();
                row = dataTable.Rows[_index];
            }
        }

        private void loadData(int Id)
        {
            DataRow[] dataRows = Id == 0 ? dataTable.Select() : dataTable.Select("Id='" + Id + "'");
            if (dataRows.Length > 0)
            {
                row = dataRows[0];
                txtUserName.Text = row["userName"].ToString();
                txtPassword.Text = row["password"].ToString();
                txtFullName.Text = row["fullname"].ToString();
                txtJobDes.Text = row["jobDes"].ToString();
                txtPhone1.Text = row["phone"].ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            row = null;
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = string.Empty;
                }
            }
            txtUserName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Enter the user name");
                txtUserName.Focus();
                return;
            }

            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Enter the password");
                txtPassword.Focus();
                return;
            }

            if (txtFullName.Text == string.Empty)
            {
                MessageBox.Show("Enter the Full Name");
                txtFullName.Focus();
                return;
            }

            saveData();
        }

        private void saveData()
        {
            if (row == null)
            {
                row = dataTable.NewRow();
                dataFillRow();
                dataTable.Rows.Add(row);
            }
            else
            {
                row.BeginEdit();
                dataFillRow();
                row.EndEdit();
            }

            try
            {
                adoCalss.builder = new SqlCommandBuilder(_adapter);
                _adapter.Update(dataTable);
                MessageBox.Show("Data has been updated :)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataFillRow()
        {
            row["userName"] = txtUserName.Text;
            row["password"] = txtPassword.Text;
            row["fullName"] = txtFullName.Text;
            row["jobDes"] = txtJobDes.Text;
            row["email"] = txtEmail.Text;
            row["phone"] = txtPhone1.Text;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            loadDataWithIndex(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                loadDataWithIndex(index);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < dataTable.Rows.Count - 1)
            {
                index++;
                loadDataWithIndex(index);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            loadDataWithIndex(dataTable.Rows.Count - 1);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FormSelect select = new FormSelect("select id, fullName From Users");
            select.des = "fullName";
            if (select.ShowDialog() == DialogResult.OK)
            {
                loadData(int.Parse(select.result));
            }
        }
    }
}