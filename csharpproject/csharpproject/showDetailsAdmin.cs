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
    public partial class showDetailsAdmin : Form
    {
        public showDetailsAdmin()
        {
            InitializeComponent();
        }

        private void btn_shw_details_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from passengersDetails", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            showDetailsGrid.DataSource = dataTable;
            connection.Close();
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from passengersDetails where PassportID='" + txt_passportid.Text + "'", connection);
            int check = sqlCommand.ExecuteNonQuery();
            connection.Close();
            if (check > 0)
            {
                MessageBox.Show("Passenger Deleted successfully");
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            
        }

        private void ticketCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TicketCategory().Show();
            this.Hide();
        }

        private void provideScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminScheduleProvide().Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminLogin().Show();
            this.Hide();
        }

        private void showDetailsGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            showDetailsGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            showDetailsGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGreen;
            showDetailsGrid.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Tahoma", 12); 
        }

        private void showDetailsGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            style1.ForeColor = Color.Azure;
            style1.BackColor = Color.Crimson;
            style1.Font = new Font("Tahoma", 12);


            if (e.RowIndex > -1)
            { showDetailsGrid.Rows[e.RowIndex].DefaultCellStyle = style1; }
        }

        private void showDetailsGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            style2.ForeColor = Color.Black;
            style2.BackColor = Color.WhiteSmoke;
            style2.Font = new Font("Tahoma", 12);

            if (e.RowIndex > -1)
            { showDetailsGrid.Rows[e.RowIndex].DefaultCellStyle = style2; }

        }
    }
    }

