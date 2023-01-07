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
        private static string stringConnection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tranv\Documents\Pet_c#\WindowsFormsApp1\BaseDeDatos\PetShopDb.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection GetSqlConnection()
        {
           return new SqlConnection(stringConnection);
        }
    }
}
