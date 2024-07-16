using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTrips
{
    public partial class WelcomeCustomer : Form
    {
        int CustomerId;
        String CustomerName;
        public WelcomeCustomer(int id, String name)
        {
            CustomerId = id;
            CustomerName = name;
            InitializeComponent();
        }

        private void WelcomeCustomer_Load(object sender, EventArgs e)
        {
            String name = CustomerName.Split(' ')[0];
            String welcome = "Welcom " + name + " to our Bus Trips Reservation System";
            txt_welcome.Text = welcome;
        }

        private void searchForTripsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTrips form = new SearchTrips(CustomerId, CustomerName);
            form.Show();
            this.Hide();
        }

        private void ManageReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ManageReservation form = new ManageReservation(CustomerId, CustomerName);
            //form.Show();
            //this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }
    }
}
