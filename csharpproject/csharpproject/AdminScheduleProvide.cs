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
    public partial class AdminScheduleProvide : Form
    {
        public AdminScheduleProvide()
        {
            InitializeComponent();
        }

        private void dataGridViewtakeoff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from detailedTakeoff", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewtakeoff.DataSource = dataTable;
            connection.Close();
        }

        private void btn_provide_schedule_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("update detailedTakeoff set Schedule ='" + txt_schedule.Text + "' where Username='" + txt_username.Text + "'", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            if (check > 0)
            {
                MessageBox.Show("Schedule Updated Successfully.");
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

        private void recruitPilotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PilotAdd().Show();
            this.Hide();
        }

        private void recruitCrewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddCabinCrew().Show();
            this.Hide();
        }

        private void pilotDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PilotDetails().Show();
            this.Hide();
        }

        private void crewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CrewDetails().Show();
            this.Hide();
        }

        private void dataGridViewtakeoff_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridViewtakeoff.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            dataGridViewtakeoff.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            dataGridViewtakeoff.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Tahoma", 10);
        }
    }
}
