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
    public partial class customer : BaseForm
    {

        DAL d = new DAL();
        bool recfnd;
        public customer()
        {
            InitializeComponent();
            GetMaxID();
        }

        private void GetMaxID()
        {
            object maxid = d.GetID("select max(cid)+1 from customerinfo");
            txtid.Text = maxid.ToString();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do u want to insert/update Record", "edit customer", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-78QFL1O\\SQLEXPRESS;Initial Catalog=dotnetdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            string Query = "";
            if (!recfnd)
            {
                Query = $"insert into customerinfo values('{txtid.Text}','{txtcname.Text}','{txtmobileno.Text}','{txtaddress.Text}','{txtproductid.Text}','{cmbprctname.Text}'," +
                    $"'{cmbproductbrand.Text}','{txtproductquantity.Text}','{txtpriceforoneproduct.Text}','{txttotalprice.Text}')";
            }
            else
                Query = $"update customerinfo set cid='{txtid}',cname='{txtcname}',cmobileno='{txtmobileno}',caddress='{txtaddress}'" +
                    $"pid='{txtproductid}',pname='{cmbprctname}'" +
                    $",pbrand='{cmbproductbrand}',pquantity='{txtproductquantity}',oneproductprice='{txtpriceforoneproduct}'," +
                    $"totalprice='{txttotalprice}' where cid='{txtid.Text}'";

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from customerinfo";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    grddata.DataSource = dt;
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


            //if (MessageBox.Show("Do you want to insert/update Record", "Edit Customer", MessageBoxButtons.YesNo) == DialogResult.No)
            //    return;

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=DESKTOP-78QFL1O\\SQLEXPRESS;Initial Catalog=dotnetdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            //try
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandText = "sp_InsertDataIntoTables";

            //    cmd.Parameters.AddWithValue("@cid", int.Parse(txtid.Text));
            //    cmd.Parameters.AddWithValue("@cname", txtcname.Text);
            //    cmd.Parameters.AddWithValue("@cmobileno", txtmobileno.Text);
            //    cmd.Parameters.AddWithValue("@caddress", txtaddress.Text);
            //    cmd.Parameters.AddWithValue("@pid", txtproductid.Text);
            //    cmd.Parameters.AddWithValue("@pname", cmbprctname.Text);
            //    cmd.Parameters.AddWithValue("@pbrand", cmbproductbrand.Text);
            //    cmd.Parameters.AddWithValue("@pquantity", int.Parse(txtproductquantity.Text));
            //    cmd.Parameters.AddWithValue("@oneproductprice", int.Parse(txtpriceforoneproduct.Text));
            //    cmd.Parameters.AddWithValue("@totalprice", int.Parse(txttotalprice.Text));

            //    // Execute the stored procedure
            //    SqlDataReader reader = cmd.ExecuteReader();

            //    // You can optionally read the result sets here if needed

            //    MessageBox.Show("Record insert/update success");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do u want to Delete", "Delete customer", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string Query = "Delete from customerinfo where cid=" + txtid.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-78QFL1O\\SQLEXPRESS;Initial Catalog=dotnetdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = Query;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                MessageBox.Show("Record Delete");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void txttotalprice_TextChanged(object sender, EventArgs e)
        {
            txttotalprice.Text = (Convert.ToInt32(txtproductquantity.Text) * Convert.ToInt32(txtpriceforoneproduct.Text)).ToString();
        }

        private void txtid_Validating(object sender, CancelEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-78QFL1O\\SQLEXPRESS;Initial Catalog=dotnetdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from customerinfo where cid=" + txtid.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr != null && rdr.HasRows)
                {
                    rdr.Read();
                    txtcname.Text = rdr["cname"].ToString();
                    txtmobileno.Text = rdr["cmobileno"].ToString();
                    txtaddress.Text = rdr["caddress"].ToString();
                    txtproductid.Text = rdr["pid"].ToString();
                    cmbprctname.Text = rdr["pname"].ToString();
                    cmbproductbrand.Text = rdr["pbrand"].ToString();
                    txtproductquantity.Text = rdr["pquantity"].ToString();
                    txtpriceforoneproduct.Text = rdr["oneproductprice"].ToString();
                    txttotalprice.Text = rdr["totalprice"].ToString();

                }
                else
                {
                    txtcname.Text = "";
                    txtmobileno.Text = "";
                    txtaddress.Text = "";
                    txtproductid.Text = "";
                    cmbprctname.Text = "";
                    cmbproductbrand.Text = "";
                    txtproductquantity.Text = "";
                    txtpriceforoneproduct.Text = "";
                    txttotalprice.Text = "";
                    //txtid.Focus();
                }

                rdr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //private void btnshowgrid_Click(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = "Data Source=DESKTOP-78QFL1O\\SQLEXPRESS;Initial Catalog=dotnetdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        //    try
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandText = "select * from customerinfo";
        //        cmd.Connection = con;
        //        DataTable dt = new DataTable();
        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        dt.Load(rdr);
        //        grddata.DataSource = dt;
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
