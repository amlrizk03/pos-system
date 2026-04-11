using PointOfSale.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Forms
{
    public partial class FormCategories : Form
    {
        public FormCategories()
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

        private void FormCategories_Load(object sender, EventArgs e)
        {
            _adapter = new SqlDataAdapter("select * From Categories", adoCalss.sqlCn);
            dataTable = new DataTable();
            _adapter.Fill(dataTable);
            index = 0;
            loadData(0);

        }
        private void loadDataWithIndex(int _index)
        {
            index=_index;
            if (dataTable.Rows.Count > 0&& _index>=0& _index<=dataTable.Rows.Count-1) 
            {
                txtDes.Text =dataTable.Rows [_index]["DES"].ToString();
              
                row=dataTable.Rows[_index];
            }

            
        }
        private void loadData(int Id)
        {
            DataRow[] dataRows = null;
            if (Id == 0)
            {
                dataRows = dataTable.Select();
            }
            else
            {
                dataRows = dataTable.Select("Id='" + Id + "'");
            }
            if (dataRows.Length > 0)
            {
                row = dataRows[0];
                txtDes.Text = row["DES"].ToString();
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
            txtDes.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDes.Text == string.Empty)
            {
                MessageBox.Show("Enter the DES");
                txtDes.Focus();
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
                MessageBox.Show("Date has been updated:)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dataFillRow()
        {
            row["DES"] = txtDes.Text;
        

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
            FormSelect select = new FormSelect("select id, DES From Categories");
            select.des = "DES";
            if (select.ShowDialog() == DialogResult.OK)
            {
                loadData(int.Parse(select.result));
            }


        }
    }
}
