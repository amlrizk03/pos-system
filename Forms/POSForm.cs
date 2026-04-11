using PointOfSale.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Forms
{
    public partial class POSForm : Form
    {
        public POSForm()
        {
            InitializeComponent();
        }

        private SqlDataAdapter adapter;
        private DataTable _itemsDt;

        private void POSForm_Load(object sender, EventArgs e)
        {
            Helper.fillComboBox(cmbPayment, "SELECT id, DES FROM Payments");
            fillCategories();
            btn0.Click += num_Click;
            btn1.Click += num_Click;
            btn2.Click += num_Click;
            btn3.Click += num_Click;
            btn4.Click += num_Click;
            btn5.Click += num_Click;
            btn6.Click += num_Click;
            btn7.Click += num_Click;
            btn8.Click += num_Click;
            btn9.Click += num_Click;
            btnDot.Click += num_Click;
            btnCancel2.Click += num_Click;
        }

        private void fillCategories()
        {
            pnlItems.Controls.Clear();
            adapter = new SqlDataAdapter("Select id,DES From Categories", adoCalss.sqlCn);
            _itemsDt = new DataTable();
            try
            {
                adapter.Fill(_itemsDt);
                DataRow[] drs = _itemsDt.Select();
                int x = 3, y = 1, count = 3;
                pnlItems.Controls.Clear();
                Button catBtn = new Button();
                for (int i = 0; i < drs.Length; i++)
                {
                    catBtn = new Button();
                    catBtn.AccessibleName = "CAT";
                    catBtn.AccessibleDescription = drs[i]["id"].ToString();
                    catBtn.Name = "btnCat" + drs[i]["id"].ToString();
                    catBtn.Text = drs[i]["DES"].ToString();
                    catBtn.Size = new Size(100, 100);
                    catBtn.Location = new Point(x, y);
                    catBtn.Click += cBtn_Click;
                    pnlItems.Controls.Add(catBtn);
                    x += 103;
                    if (count == 5)
                    {
                        y += 103;
                        x = 1;
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            adapter.Dispose();
            _itemsDt.Dispose();
        }

        private void cBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.AccessibleName == "CAT")
            {
                string CatId = button.AccessibleDescription;
                fillItems(CatId);
            }
            else if (button.AccessibleName == "IT")
            {
                double x = 0;
                double.TryParse(txtItemQTY.Text, out x);
                if (x == 0)
                {
                    x = 1;
                }
                double totalPrice = 0;
                double.TryParse(button.Tag.ToString(), out totalPrice);
                totalPrice = x * totalPrice;
                dgvItems.Rows.Add(new object[]
                {
                    button.AccessibleDefaultActionDescription,
                    button.Text,
                    x,
                    totalPrice
                });
                txtItemQTY.Text = "0";
            }
            else
            {
                fillCategories();
            }
            calCheck();
            if (adoCalss.sqlCn != null && adoCalss.sqlCn.State == ConnectionState.Open)
            {
                adoCalss.sqlCn.Close();
            }
        }

        private void fillItems(string catId)
        {
            pnlItems.Controls.Clear();
            adapter = new SqlDataAdapter("Select * From Items WHERE CategoryId= '" + catId + "'", adoCalss.sqlCn);
            _itemsDt = new DataTable();

            try
            {
                adapter.Fill(_itemsDt);
                DataRow[] drs = _itemsDt.Select();
                int x = 3, y = 3, count = 1;
                pnlItems.Controls.Clear();
                Button catBtn;

                for (int i = 0; i < drs.Length; i++)
                {
                    catBtn = new Button();
                    catBtn.AccessibleName = "IT";
                    catBtn.AccessibleDescription = drs[i]["id"].ToString();
                    catBtn.Name = "btnCat" + drs[i]["id"].ToString();
                    catBtn.Text = drs[i]["DES"].ToString();
                    catBtn.Tag = drs[i]["price"].ToString();
                    catBtn.TextAlign = ContentAlignment.BottomRight;

                    if (drs[i]["itemImg"] != DBNull.Value)
                    {
                        using (var stream = new MemoryStream((byte[])drs[i]["itemImg"]))
                        {
                            catBtn.Image = Image.FromStream(stream);
                        }
                    }

                    catBtn.Size = new Size(100, 100);
                    catBtn.Location = new Point(x, y);
                    catBtn.Click += cBtn_Click;
                    pnlItems.Controls.Add(catBtn);

                    x += 103;
                    if (count == 5)
                    {
                        y += 103;
                        x = 1;
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }

                catBtn = new Button();
                catBtn.Size = new Size(100, 100);
                catBtn.AccessibleName = "CAT";
                catBtn.Name = "btnEnd" + catId;
                catBtn.Text = "Cancel";
                catBtn.Location = new Point(x, y);
                catBtn.Click += cBtn_Click;
                pnlItems.Controls.Add(catBtn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            adapter.Dispose();
            _itemsDt.Dispose();
            if (adoCalss.sqlCn != null && adoCalss.sqlCn.State == ConnectionState.Open)
            {
                adoCalss.sqlCn.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count > 0)
            {
                dgvItems.Rows.Remove(dgvItems.CurrentRow);
                calCheck();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvItems.Rows.Clear();
            calCheck();
        }

        private void calCheck()
        {
            double x = 0;
            double result = 0;
            for (int i = 0; i <= dgvItems.Rows.Count - 1; i++)
            {
                double.TryParse(dgvItems[ColPrice.Index, i].Value.ToString(), out x);
                result += x;
            }
            txtTotal.Text = result.ToString();
        }

        private void num_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "C")
            {
                txtItemQTY.Text = "0";
            }
            else if (button.Text == ".")
            {
                if (!txtItemQTY.Text.Contains("."))
                {
                    if (int.Parse(txtItemQTY.Text) == 0)
                    {
                        txtItemQTY.Text = "0.";
                    }
                    else
                    {
                        txtItemQTY.Text += ".";
                    }
                }
            }
            else
            {
                if (int.Parse(txtItemQTY.Text) == 0)
                {
                    txtItemQTY.Text = button.Text;
                }
                else
                {
                    txtItemQTY.Text += button.Text;
                }
            }
        }
    }
}