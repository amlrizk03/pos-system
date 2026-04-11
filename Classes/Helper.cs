using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;

namespace PointOfSale.Classes
{
    public class Helper
    {
        public static Byte[] ImageToByte(Image image)
        {
            Byte[] bResult = null;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                bResult = ms.ToArray();
            }

            return bResult;
        }

        public static Image ByteToImage(object bObj)
        {
            Byte[] myImg = (Byte[])bObj;
            Image image = null;
            using (MemoryStream ms = new MemoryStream(myImg, 0, myImg.Length))
            {
                ms.Write(myImg, 0, myImg.Length);
                image = Image.FromStream(ms, true);
            }

            return image;
        }

        public static string getComboItemVal(ComboBox combo, string key)
        {
            string x = string.Empty;
            foreach (var item in combo.Items)
            {
                ComboItem cItem = (ComboItem)item;
                if (cItem.Id == key)
                {
                    x = cItem.DES;
                }
            }
            return x;
        }

        public static void fillComboBox(ComboBox combo,string selectText)
        {
            SqlCommand sqlCommand = new SqlCommand(selectText,adoCalss.sqlCn);
            SqlDataReader reader = null;
            try
            {
                if (adoCalss.sqlCn.State != ConnectionState.Open)
                {
                    adoCalss.sqlCn.Open();
                }
                combo.Items.Clear();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ComboItem item =new ComboItem(
                        reader[0].ToString(),
                        reader[1].ToString());
                    combo.Items.Add(item);
                }
                combo.Items.Add(new ComboItem("", ""));
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
