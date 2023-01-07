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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }


        private string userName;
        private string passWord;

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }

       
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tranv\Documents\Pet_c#\WindowsFormsApp1\BaseDeDatos\PetShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        
     
        public Login(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btlReset_Click(object sender, EventArgs e)
        {
            Nametxt.Text = "";
            Passwordtxt.Text = "";
        }


        Modify modify = new Modify();
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string user = Nametxt.Text;
            string pass = Passwordtxt.Text;
            if(user.Trim()== "")
            {
                MessageBox.Show("Vui long nhap ten tai khoan!");
            }
           else if(pass.Trim() == "")
            {
                MessageBox.Show("Vui long nhap mat khau!");
            }
            else
            {
               //string query1 = "Select * from AccTbl where userName = '"+user+"' and passWord = '"+pass+"'";
               string query = "Select * from EmployeeTbl where EmpName = '" + user + "' and EmpPass = '" + pass + "'";
                if (modify.Accounts(query).Count!=0)
                {
                    MessageBox.Show("Dang nhap thanh cong!", "THong Bao", MessageBoxButtons.OK,MessageBoxIcon.Information );
                    Home obj = new Home();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ten tai khoan hoac mat khau khong chinh xac","Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        //
        private void Loginbtn_Click1(object sender, EventArgs e)
        {
            if (Nametxt.Text == "admin" && Passwordtxt.Text == "admin")
            {
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai Tên Tài Khoản Hoặc Mật Khẩu", "Lỗi");
                Nametxt.Focus();
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            CreateAccount obj = new CreateAccount();
            obj.Show();
            this.Hide();
        }
    }
}
