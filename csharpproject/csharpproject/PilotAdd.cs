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
    public partial class PilotAdd : Form
    {
        public PilotAdd()
        {
            InitializeComponent();
        }

        private void btn_pilot_recruit_Click(object sender, EventArgs e)
        {
            Employee employee = new pilot(txt_pilotname.Text, Convert.ToInt32(txt_pilotID.Text), Convert.ToInt32(txt_pilotage.Text), comboBox_pilotgender.Text, comboBox_pilotbloodGroup.Text, comboBox_pilotShift.Text);

            employee.name = txt_pilotname.Text;
            employee.id = Convert.ToInt32(txt_pilotID.Text);
            employee.age = Convert.ToInt32(txt_pilotage.Text);
            employee.Gender = comboBox_pilotgender.Text;
            employee.bloodGroup = comboBox_pilotbloodGroup.Text;
            employee.shift = comboBox_pilotShift.Text;

            if (string.IsNullOrEmpty(employee.name) & string.IsNullOrEmpty(employee.id.ToString()) & string.IsNullOrEmpty(employee.age.ToString()) & string.IsNullOrEmpty(employee.Gender) & string.IsNullOrEmpty(employee.bloodGroup) & string.IsNullOrEmpty(employee.shift) )
            {
                MessageBox.Show("All Information needed !!!");
            }

            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into pilotinformation(Name, ID, Age, Gender, BloodGroup, Shift) values( '" + employee.name + "' , '" + employee.id + "', '" + employee.age + "', '" + employee.Gender + "', '" + employee.bloodGroup + "', '" + employee.shift + "')", conn);
                int check = cmd.ExecuteNonQuery();
                conn.Close();
                if (check > 0) { MessageBox.Show("Pilot Recruited Successfully"); }
                else { MessageBox.Show("Failed"); }
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new showDetailsAdmin().Show();
            this.Hide();
        }

        private void ticketCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TicketCategory().Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PilotDetails().Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AdminLogin().Show();
            this.Hide();
        }
    }
}

