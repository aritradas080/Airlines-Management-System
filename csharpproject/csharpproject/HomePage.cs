using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpproject
{
    public partial class HomePage : Form
    {
        public HomePage(string str)
        {
            InitializeComponent();
            this.txt_username.Text = str;
        }

        private void page2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateProfile updateprofile = new updateProfile(txt_username.Text);
            updateprofile.ShowDialog();
            this.Hide();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketBooking ticketBooking = new TicketBooking(txt_username.Text);
            ticketBooking.ShowDialog();
            this.Hide();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new PassengerLogin().Show();
            this.Hide();
        }
    }
}
