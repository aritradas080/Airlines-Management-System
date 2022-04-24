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
    public partial class PilotDetails : Form
    {
        public PilotDetails()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from pilotInformation", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView_pilot.DataSource = dataTable;
            connection.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from pilotInformation where ID='" + txt_pilotid.Text + "'", connection);
            int check = sqlCommand.ExecuteNonQuery();
            connection.Close();
            if (check > 0)
            {
                MessageBox.Show("Pilot Deleted successfully");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("update pilotInformation set Shift ='" + comboBoxpilotShift.Text + "' where ID='" + txt_pilotid.Text + "'", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            if (check > 0)
            {
                MessageBox.Show("Pilot Information Updated Successfully");
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new showDetailsAdmin().Show();
            this.Hide();
        }

        private void addCabinCrewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PilotAdd().Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminLogin().Show();
            this.Hide();
        }

        private void dataGridView_pilot_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView_pilot.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            dataGridView_pilot.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            dataGridView_pilot.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Tahoma", 12);
        }
    }
}
