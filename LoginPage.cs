using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginForm
{
    public partial class LoginForm : Form
    {
      

        public LoginForm()
        {
            InitializeComponent();
        }

      
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-78QFL1O\\SQLEXPRESS;Initial Catalog=dotnetdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM login WHERE username = @username AND password = @password", con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPass.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                string cmbItemValue = cmdRole.SelectedItem?.ToString();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["usertype"].ToString() == cmbItemValue)
                        {
                            MessageBox.Show("You are logged in as " + dt.Rows[i]["usertype"]);
                            if (cmdRole.SelectedIndex == 0)
                            {
                                productstored ff = new productstored();
                                ff.Show();
                                this.Hide();

                                //customer f = new customer();
                                //f.Show();
                                //this.Hide();
                            }
                            else
                            {
                                customer f = new customer();
                                f.Show();
                                this.Hide();

                                //productstored ff = new productstored();
                                //ff.Show();
                                //this.Hide();
                            }
                            return;
                        }
                    }
                    MessageBox.Show("User type not found.");
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
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



        private void chkpass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = chkpass.Checked ? '\0' : '*';
        }
    }
}
