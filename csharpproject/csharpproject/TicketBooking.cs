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
    public partial class TicketBooking : Form
    {
        public TicketBooking(string str_val1)
        {
            InitializeComponent();
            txt_box_ticket.Text = str_val1;
        }

        private void txt_box_ticket_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from tickets", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            ItemGridView.DataSource = dataTable;
            connection.Close();
        }

        private void totalPrice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void combo_items_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            int val3 = Convert.ToInt32(ItemGridView.Rows[0].Cells[1].Value);
            int val4 = Convert.ToInt32(ItemGridView.Rows[1].Cells[1].Value);
            if (combo_items.Text == "First Class")
            {
                int tot_price = val3 * Convert.ToInt32(txt_amount.Text);
                totalPrice.Text = tot_price.ToString();
            }
            else
            {
                int tot_price = val4 * Convert.ToInt32(txt_amount.Text);
                totalPrice.Text = tot_price.ToString();
            }
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into detailedTakeoff(Username, Category, Amount, TotalPrice, Schedule) values( '" +txt_box_ticket.Text + "' , '" + combo_items.Text + "', '" + txt_amount.Text + "', '" + totalPrice.Text + "', '" + null + "')", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            if (check > 0) { MessageBox.Show("Booked Successfully"); }
            else { MessageBox.Show("Failed"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
            conn.Open();

            string UserName = txt_box_ticket.Text;
            string Schedule = txt_view_schedule.Text;

            SqlCommand cmd = new SqlCommand("SELECT Schedule FROM detailedTakeoff where Username='" + txt_box_ticket.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            System.Data.SqlClient.SqlDataReader dr = null;
            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                this.txt_view_schedule.Text = dr["Schedule"].ToString();
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ARITRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from detailedTakeoff where Username ='" + txt_box_ticket.Text + "'", connection);
            int check = sqlCommand.ExecuteNonQuery();
            connection.Close();
            if (check > 0)
            {
                MessageBox.Show("Deleted successfully");
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HomePage(txt_box_ticket.Text).Show();
            this.Hide();
        }

        private void bookTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new updateProfile(txt_box_ticket.Text).Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PassengerLogin().Show();
            this.Hide();
        }

        private void ItemGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ItemGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            ItemGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            ItemGridView.Rows[e.RowIndex].DefaultCellStyle.Font= new Font("Tahoma", 15); ;
        }
    }
    
}
