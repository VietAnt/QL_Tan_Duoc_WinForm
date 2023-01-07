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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            DisplayCustomers();
            Clear();
        }
        SqlConnection con = new SqlConnection(@"Data Source=NIKE;Initial Catalog=C:\USERS\TRANV\ONEDRIVE\DESKTOP\QL_TÂN_DƯỢC\DATABASE\PETSHOPDB.MDF;Integrated Security=True");
        int key = 0;
        private void DisplayCustomers()
        {
            try
            {
                con.Open();
                string Query = " select *" +
                               " from ProductTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProductDGV.DataSource = ds.Tables[0];
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
        private void Clear()
        {
            ProductName.Text = "";
            ProductoPrice.Text = "";
            ProductQuantity.Text = "";
            cboProductCategory.SelectedIndex = 0;
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (ProductName.Text == "")
            {
                MessageBox.Show("Please Add a Name");
                return;
            }
            if (ProductoPrice.Text == "")
            {
                MessageBox.Show("Please Add a Price");
                return;
            }
            if (ProductQuantity.Text == "")
            {
                MessageBox.Show("Please Add a Quantity");
                return;
            }
            else if (ProductName.Text != "" && ProductoPrice.Text != "" && ProductQuantity.Text != "")
            {

                //PrName
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ProductTbl (PrName,PrCat,PrQty,PrPrice) values(@PN,@PC,@PQ,@PP)", con); 
                    cmd.Parameters.AddWithValue("@PN", ProductName.Text);
                    cmd.Parameters.AddWithValue("@PC", cboProductCategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PQ", ProductQuantity.Text);
                    cmd.Parameters.AddWithValue("@PP", ProductoPrice.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product : " + ProductName.Text + " Added");
                    con.Close();
                    DisplayCustomers();
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

        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(ProductDGV.SelectedRows[0].Cells[0].Value.ToString());
            ProductName.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
            cboProductCategory.Text = ProductDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProductQuantity.Text = ProductDGV.SelectedRows[0].Cells[3].Value.ToString();
            ProductoPrice.Text = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("You nedd select a Product");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ProductTbl where PrId = @PKey", con);
                    cmd.Parameters.AddWithValue("@PKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted");
                    con.Close();
                    DisplayCustomers();
                    key = 0;
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

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (ProductName.Text == "")
            {
                MessageBox.Show("Please Add a Name");
                return;
            }
            if (ProductoPrice.Text == "")
            {
                MessageBox.Show("Please Add a Price");
                return;
            }
            if (ProductQuantity.Text == "")
            {
                MessageBox.Show("Please Add a Quantity");
                return;
            }
            else if (ProductName.Text != "" && ProductoPrice.Text != "" && ProductQuantity.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update ProductTbl set" +
                                                    " PrName = @PN ," +
                                                    " PrCat = @PC  ," +
                                                    " PrQty = @PQ  ," +
                                                    " PrPrice = @PP " +
                                                    " where PrId = @PKey ", con);
                    cmd.Parameters.AddWithValue("@PN", ProductName.Text);
                    cmd.Parameters.AddWithValue("@PC", cboProductCategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PQ", ProductQuantity.Text);
                    cmd.Parameters.AddWithValue("@PP", ProductoPrice.Text);
                    cmd.Parameters.AddWithValue("@PKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prodcut Updated");
                    con.Close();
                    DisplayCustomers();
                    key = 0;
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

        private void label1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
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

        private void label11_Click(object sender, EventArgs e)
        {

        }
        public void LoadGrid()
        {
            try
            {
                con.Open();
                string Query = " select *" +
                               " from ProductTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProductDGV.DataSource = ds.Tables[0];
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
        public void LoardGridByKeyword()
        {
            try
            {
                con.Open();
                string Query = " select *" +
                               " from ProductTbl   where  PrName like '%" + txtKeyword.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProductDGV.DataSource = ds.Tables[0];
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

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            //timkiem_san_pham
            LoardGridByKeyword();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          LoadGrid();
        }
    }
}
