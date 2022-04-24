using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpproject
{
    public partial class PassengerLogin : Form
    {
        public PassengerLogin()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new PassengerSignUp().Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //HomePage h = new HomePage(txt_username.Text);
            //h.ShowDialog();
            if (string.IsNullOrEmpty(this.txt_username.Text) | string.IsNullOrEmpty(this.txt_password.Text))
            {
                MessageBox.Show("provide User Name and Password");
            }
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
            conn.Open();
            string UserName = txt_username.Text;
            string Password = txt_password.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM passengersDetails WHERE Username = '" + txt_username.Text + "' and Password = '" + txt_password.Text + "'", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            System.Data.SqlClient.SqlDataReader dr = null;
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
                con.ConnectionString = @"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
                con.Open();

                if (this.txt_username.Text == dr["UserName"].ToString() & this.txt_password.Text == dr["Password"].ToString())
                {
                    MessageBox.Show("*** Login Successful ***");
                    HomePage h = new HomePage(txt_username.Text);
                    h.ShowDialog();
                    

                    // f.CreateUserAccountToolStripMenuItem.Enabled = false;
                    this.Hide();
                }








            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}