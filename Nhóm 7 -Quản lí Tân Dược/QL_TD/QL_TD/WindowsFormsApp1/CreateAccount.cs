using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        //checkout
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tranv\Documents\Pet_c#\WindowsFormsApp1\BaseDeDatos\PetShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        int key = 0;
        
        //reset
        private void Clear()
        {
            tb_passWord.Text = "";
            tb_userName.Text = "";
        }
        //

        private void Createbtn_Click(object sender, EventArgs e)
        {
            if (tb_userName.Text == "")
            {
                MessageBox.Show("Please Add a UserName");
                return;
            }
            if (tb_passWord.Text == "")
            {
                MessageBox.Show("Please Add a PassWord");
                return;
            }
           
            else if (tb_userName.Text != "" && tb_passWord.Text != "" )
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AccTbl (userName,passWord) values(@CN,@CA)", con);
                    cmd.Parameters.AddWithValue("@CN", tb_userName.Text);
                    cmd.Parameters.AddWithValue("@CA", tb_passWord.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("UserName : " + tb_userName.Text + " Added");
                    con.Close();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There's been a problem ==>" + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
