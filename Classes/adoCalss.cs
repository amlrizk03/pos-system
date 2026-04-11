using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PointOfSale.Classes
{
    public class adoCalss
    {
        //tthis class adds the connection and you can all the properities in it
        public static SqlConnection sqlCn;
        public static SqlCommandBuilder builder;
        public static void setConnection()
        {
            sqlCn = new SqlConnection(PointOfSale.Properties.Settings.Default.Connection);
        }

    }
}
