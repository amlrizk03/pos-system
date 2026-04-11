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
    public partial class FormItmes : Form
    {
        public FormItmes()
        {
            InitializeComponent();
        }

        private SqlDataAdapter _adapter;
        private DataTable dataTable;
        private DataRow row;
        private int index;

        private void FormItmes_Load(object sender, EventArgs e)
        {
            Helper.fillComboBox(cmbCategory, "SELECT id, DES FROM Categories");
            _adapter = new SqlDataAdapter("Select * From Items", adoCalss.sqlCn);
            dataTable = new DataTable();
            _adapter.Fill(dataTable);
            index = 0;
            loadData(0);

        }
        private void loadDataWithIndex(int _index)
        {
            index = _index;
            if (dataTable.Rows.Count > 0 && _index >= 0 & _index <= dataTable.Rows.Count - 1)
            {
                txtDes.Text = dataTable.Rows[_index]["DES"].ToString();
                cmbCategory.Text = Helper.getComboItemVal(cmbCategory, dataTable.Rows[_index]["CategoryId"].ToString());
                txtPrice.Text = dataTable.Rows[_index]["price"].ToString();
                txtNotes.Text = dataTable.Rows[_index]["notes"].ToString();
                if (dataTable.Rows[_index]["itemImg"] != DBNull.Value)
                {
                    pbItem.BackgroundImage = Helper.ByteToImage(dataTable.Rows[_index]["itemImg"]);
                }
                else
                {
                    pbItem.BackgroundImage = null;
                }


                row = dataTable.Rows[_index];
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
                cmbCategory.Text = Helper.getComboItemVal(cmbCategory, row["CategoryId"].ToString());
                txtPrice.Text = row["price"].ToString();

                if (row["itemImg"] != DBNull.Value)
                {
                    pbItem.BackgroundImage = Helper.ByteToImage(row["itemImg"]);
                }
                else
                {
                    pbItem.BackgroundImage = null;
                }
                txtNotes.Text = row["notes"].ToString();
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
                if (ctr is ComboBox)
                {
                    ctr.Text = "";
                }
            }
            pbItem.BackgroundImage = null;
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
            if (cmbCategory.Text == string.Empty)
            {
                MessageBox.Show("Select the Category");
                return;
            }
            if (int.Parse(txtPrice.Text) <= 0)
            {
                MessageBox.Show("Enter the price");
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
                MessageBox.Show("Data has been updated:)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dataFillRow()
        {
            row["DES"] = txtDes.Text;
            row["CategoryId"] = ((ComboItem)cmbCategory.SelectedItem).Id;
            row["price"] = txtPrice.Text;

            if (pbItem.BackgroundImage != null)
            {
                row["itemImg"] = Helper.ImageToByte(pbItem.BackgroundImage);
            }
            row["notes"] = txtNotes.Text;

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
            FormSelect select = new FormSelect("SELECT id, DES FROM Items");
            select.des = "DES";
            if (select.ShowDialog() == DialogResult.OK)
            {
                loadData(int.Parse(select.result));
            }

        }


        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Images|*.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
      
                txtImage.Text = fileDialog.FileName;
                pbItem.BackgroundImage = new Bitmap(txtImage.Text);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
