using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PointOfSale.Classes;

namespace PointOfSale.Forms
{
    public partial class MainOptions : Form
    {
        public MainOptions()
        {
            InitializeComponent();
        }

        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataRow Row;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainOptions_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select Top 1 * From Options", adoCalss.sqlCn);
            dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    Row = dataTable.Rows[0];
                    for (int i = 0; i <= dataTable.Rows.Count - 1; i++)
                    {
                        txtResetName.Text = dataTable.Rows[i]["ResetName"].ToString();
                        txtResetAddress1.Text = dataTable.Rows[i]["ResetAddress1"].ToString();
                        txtPhone.Text = dataTable.Rows[i]["Phone"].ToString();
                        txtPrinter.Text = dataTable.Rows[i]["printerName"].ToString();
                        txtReceiptLine1.Text = dataTable.Rows[i]["receiptLine1"].ToString();
                        txtReceiptLine2.Text = dataTable.Rows[i]["receiptLine2"].ToString();
                        if (dataTable.Rows[i]["logo"] != DBNull.Value)
                        {
                            picBox1.BackgroundImage = Helper.ByteToImage(dataTable.Rows[i]["logo"]);
                        }
                    }
                }
                else
                {
                    Row = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save New Date", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                saveData();
            }
        }

        private void saveData()
        {
            if (txtResetName.Text == string.Empty)
            {
                MessageBox.Show("Please enter the restaurant name");
                txtResetName.Focus();
                return;
            }

            if (txtPhone.Text == string.Empty)
            {
                MessageBox.Show("Please enter the restaurant name");
                txtPhone.Focus();
                return;
            }

            if (Row == null)
            {
                Row = dataTable.NewRow();
                dataFillRow();
                dataTable.Rows.Add(Row);
            }
            else
            {
                Row.BeginEdit();
                dataFillRow();
                Row.EndEdit();
            }

            try
            {
                adoCalss.builder = new SqlCommandBuilder(adapter);
                adapter.Update(dataTable);
                MessageBox.Show("Data has been updated :)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataFillRow()
        {
            Row["ResetName"] = txtResetName.Text;
            Row["ResetAddress1"] = txtResetAddress1.Text;
            Row["ResetAddress2"] = txtResetAddress2.Text;
            Row["Phone"] = txtPhone.Text;
            Row["printerName"] = txtPrinter.Text;
            Row["receiptLine1"] = txtReceiptLine1.Text;
            Row["receiptLine2"] = txtReceiptLine2.Text;

            if (picBox1.BackgroundImage != null)
            {
                Row["logo"] = Helper.ImageToByte(picBox1.BackgroundImage);
            }
        }

        private void btnSelectPic_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fileDaialog = new OpenFileDialog();
            fileDaialog.Filter = "Images|*.png";
            if (fileDaialog.ShowDialog() == DialogResult.OK)
            {
                txtPic1.Text = fileDaialog.FileName;
                picBox1.BackgroundImage = new Bitmap(txtPic1.Text);
            }
        }
    }
}