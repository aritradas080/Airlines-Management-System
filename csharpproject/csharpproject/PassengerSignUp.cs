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

namespace csharpproject
{
    public partial class PassengerSignUp : Form
    {
        public PassengerSignUp()
        {
            InitializeComponent();
        }

        private void back_to_login_Click(object sender, EventArgs e)
        {
            new PassengerLogin().Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValue.Text = comboBox1.Text;
            lblValue.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dob = dateTimePicker1.Value;
            DateTime cur = DateTime.Now;
            TimeSpan timespan = cur - dob;
            txt_age.Text = (timespan.TotalDays / 365).ToString("0");
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Person p = new Passenger(txt_username.Text, txt_email.Text, txt_password.Text, txt_nid.Text, txt_passportID.Text, Convert.ToInt32(txt_age.Text), comboBox1.Text);
            p.username = txt_username.Text;
            p.email = txt_email.Text;
            p.password = txt_password.Text;
            p.nid = txt_nid.Text;
            p.passportid = txt_passportID.Text;
            p.age = Convert.ToInt32(txt_age.Text);
            p.gender = comboBox1.Text;


            if (string.IsNullOrEmpty(p.username) & string.IsNullOrEmpty(p.email) & string.IsNullOrEmpty(p.password) & string.IsNullOrEmpty(p.nid) & string.IsNullOrEmpty(p.passportid) & string.IsNullOrEmpty(p.age.ToString()) & string.IsNullOrEmpty(p.gender))
            {
                MessageBox.Show("provide User Information");
            }

            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into passengersDetails(Username, Email, Password, NID, PassportID, Age, Gender) values( '" + p.username + "' , '" + p.email + "', '" + p.password + "', '" + p.nid + "', '" + p.passportid + "', '" + p.age + "', '" + p.gender + "')", conn);
                int check = cmd.ExecuteNonQuery();
                conn.Close();
                if (check > 0) { MessageBox.Show("Registration Successfully"); }
                else { MessageBox.Show("Inserted Failed"); }
            }
        }

        /*new PassengerLogin().Show();
            this.Hide();
            SqlConnection connection = new SqlConnection(@"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into passengersDetails(Username, Email, Password, NID, PassportID , Age, Gender) values( '" + txt_username.Text + "' , '" + txt_email.Text + "', '" + txt_password.Text + "', '" + txt_nid.Text + "', '" + txt_passportID.Text + "', '" + Convert.ToInt32(txt_age.Text) + "', '" + comboBox1.Text + "')", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            if (check > 0) { MessageBox.Show("Inserted Successfully"); }
            else { MessageBox.Show("Data Inserted Failed"); }*/

        }
    }

