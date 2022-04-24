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
    public partial class TicketCategory : Form
    {
        public TicketCategory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from tickets", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("update tickets set Price ='" + Convert.ToInt32(txt_price.Text) + "' where Category='" + combo_category.Text + "'", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            if (check > 0)
            {
                MessageBox.Show("Price Updated Successfully");
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new showDetailsAdmin().Show();
            this.Hide();
        }

        private void scheduleProvideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminScheduleProvide().Show();
            this.Hide();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Tahoma", 12);
        }
    }
}
