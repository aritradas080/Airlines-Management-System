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
    public partial class updateProfile : Form
    {
        public updateProfile(string val2)
        {
            InitializeComponent();
            txt_username.Text = val2;
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_showdetails_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM passengersDetails WHERE Username = '" + txt_username.Text+ "'", conn);

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

                txt_nid.Text = dr["NID"].ToString();
                txt_passportid.Text = dr["PassportID"].ToString();
                txt_age.Text = dr["Age"].ToString();
                txt_gender.Text = dr["Gender"].ToString();

            }


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("update passengersDetails set Email = '" + txt_email.Text + "' , Password = '" + txt_password.Text + "' where Username ='" + txt_username.Text + "'", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            if (check > 0)
            {
                MessageBox.Show("Updated Successfully");
            }

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HomePage(txt_username.Text).Show();
            this.Hide();

        }

        private void bookTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TicketBooking(txt_username.Text).Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PassengerLogin().Show();
            this.Hide();
        }
    }
}
