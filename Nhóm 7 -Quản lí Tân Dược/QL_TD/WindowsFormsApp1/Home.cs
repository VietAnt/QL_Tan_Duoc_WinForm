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

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            CountDogos();
            CountCatos();
            CountCates();
            CountCatas();
            Finance();
            NameText();


        }
        SqlConnection con = new SqlConnection(@"Data Source=NIKE;Initial Catalog=C:\USERS\TRANV\ONEDRIVE\DESKTOP\QL_TÂN_DƯỢC\DATABASE\PETSHOPDB.MDF;Integrated Security=True");

        private void CountDogos()
        {
            string cat = "Thuốc Kháng Sinh";
            try
            {
                con.Open();
            //    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ProductTbl where PrCat = '" + cat + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ProductTbl where PrCat LIKE N'Thuốc Kháng Sinh'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DogsLbl.Text = dt.Rows[0][0].ToString();
                con.Close();
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
        private void CountCatos()
        {
           
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ProductTbl where PrCat LIKE N'Vitamin-Khoáng Chất'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                LblCat.Text = dt.Rows[0][0].ToString();
                con.Close();
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
        private void CountCates()
        {
            string cat = "Thuốc Ho";
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ProductTbl where PrCat LIKE N'Thuốc Ho'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BirdLbl.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's been a problem ==>" + ex.Message);
            }
            finally
            {
                //  đóng chuỗi bất kể câu lệnh có được thực thi thành công hay không
                con.Close();
            }
        }

        //thuoc
        private void CountCatas()
        {
            string cat = "Thuốc Dạ Dày";
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ProductTbl where PrCat LIKE N'Thuốc Dạ Dày'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                lb_daday.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's been a problem ==>" + ex.Message);
            }
            finally
            {
                //  đóng chuỗi bất kể câu lệnh có được thực thi thành công hay không
                con.Close();
            }
        }
        private void Finance()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select sum(Amt) from BillTbl", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                lblFinance.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's been a problem ==>" + ex.Message);
            }
            finally
            {
                //  đóng chuỗi bất kể câu lệnh có được thực thi thành công hay không
                con.Close();
            }
        }


        private void NameText()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select userName * from AccTbl ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                LbName.Text = dt.Rows[1].ToString();
                con.Close();
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

        private void label2_Click(object sender, EventArgs e)
        {
            Products obj = new Products();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Billings obj = new Billings();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void DogsLbl_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void lblFinance_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
