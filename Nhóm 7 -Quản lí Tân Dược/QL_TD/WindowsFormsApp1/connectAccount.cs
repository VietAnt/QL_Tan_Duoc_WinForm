using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public class connectAccount
    {
        private static string stringConnection = @"Data Source=NIKE;Initial Catalog=C:\USERS\TRANV\ONEDRIVE\DESKTOP\QL_TÂN_DƯỢC\DATABASE\PETSHOPDB.MDF;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
           return new SqlConnection(stringConnection);
        }
    }
}
