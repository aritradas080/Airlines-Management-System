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
    public partial class AddCabinCrew : Form
    {
        public AddCabinCrew()
        {
            InitializeComponent();
        }

        private void btn_crew_recruit_Click(object sender, EventArgs e)
        {
            Employee emp = new Crew(txt_crewname.Text, Convert.ToInt32(txt_crewID.Text), Convert.ToInt32(txt_crewage.Text), comboBox_crewgender.Text, comboBox_crewbloodGroup.Text, comboBox_crewShift.Text);
            emp.name = txt_crewname.Text;
            emp.id = Convert.ToInt32(txt_crewID.Text);
            emp.age = Convert.ToInt32(txt_crewage.Text);
            emp.Gender = comboBox_crewgender.Text;
            emp.bloodGroup = comboBox_crewbloodGroup.Text;
            emp.shift = comboBox_crewShift.Text;

            if (string.IsNullOrEmpty(emp.name) & string.IsNullOrEmpty(emp.id.ToString()) & string.IsNullOrEmpty(emp.age.ToString()) & string.IsNullOrEmpty(emp.Gender) & string.IsNullOrEmpty(emp.bloodGroup) & string.IsNullOrEmpty(emp.shift))
            {
                MessageBox.Show("All Information needed !!!");
            }

            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into crewInformation(CrewName, CrewID, CrewAge, CrewGender, CrewBloodGroup, CrewShift) values( '" + emp.name + "' , '" + emp.id + "', '" + emp.age + "', '" + emp.Gender + "', '" + emp.bloodGroup + "', '" + emp.shift + "')", conn);
                int check = cmd.ExecuteNonQuery();
                conn.Close();
                if (check > 0) { MessageBox.Show("Cabin Crew Recruited Successfully"); }
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
            new CrewDetails().Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AdminLogin().Show();
            this.Hide();
        }
    }
}
