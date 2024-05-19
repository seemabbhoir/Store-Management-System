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

namespace LoginForm
{

    public partial class productstored : BaseForm
    {
        bool recfnd;
        public productstored()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string Query = $"insert into productinfo values('{cmbproductname.Text}','{cmbproductbrand.Text}','{txtproductquantityavailable.Text}')";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-78QFL1O\\SQLEXPRESS;Initial Catalog=dotnetdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            //try
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandText = Query;
            //    cmd.Connection.Open();
            //    cmd.ExecuteNonQuery();
            //    cmd.Connection.Close();
            //    MessageBox.Show("Record saved");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //con.Close();

            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "select * from productinfo";
            //cmd.Connection = con;
            //DataTable dt = new DataTable();
            //SqlDataReader rdr = cmd.ExecuteReader();
            //dt.Load(rdr);
            //grdinformation.DataSource = dt;
            //con.Close();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from productinfo";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    grdinformation.DataSource = dt;
                    MessageBox.Show("Records fetched successfully");
                }
                else
                {
                    MessageBox.Show("No records found");
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-78QFL1O\\SQLEXPRESS;Initial Catalog=dotnetdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            string Query = "";
            if (!recfnd)
            {
                Query = $"insert into productinfo values('{cmbproductname.Text}','{cmbproductbrand.Text}','{txtproductquantityavailable.Text}')";
            }
            else
                Query = $"update productinfo set productname='{cmbproductname.Text}',selectproductbrand='{cmbproductbrand.Text}',selectproductquantity='{txtproductquantityavailable.Text}'";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = Query;
                cmd.Connection.Open();
                int res = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (res > 0)
                    MessageBox.Show("Record Update success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //private void btngridinformation_Click(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = "Data Source=DESKTOP-78QFL1O\\SQLEXPRESS;Initial Catalog=dotnetdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        //    try
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandText = "select * from productinfo";
        //        cmd.Connection = con;
        //        DataTable dt = new DataTable();
        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        dt.Load(rdr);
        //        grdinformation.DataSource = dt;
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();

        }

        
    }
}
