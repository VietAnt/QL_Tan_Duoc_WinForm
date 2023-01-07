using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.Specialized;

namespace WindowsFormsApp1
{
    public class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand; //dung de truy van cac cau lenh truy van insert,delete,update
        SqlDataReader dataReader; //Dung de doc du lieu trong bang

        public List<Account> Accounts(string query)
        {
            List<Account> accountList = new List<Account>();

            using (SqlConnection sqlConnection = connectAccount.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    //accountList.Add(new Account(dataReader.GetString(0), dataReader.GetString(1)));
                    accountList.Add(new Account(dataReader.GetInt32(0).ToString(), dataReader.GetInt32(0).ToString()));
                }
                sqlConnection.Close();
            }

                return accountList;
        }
    }
}
