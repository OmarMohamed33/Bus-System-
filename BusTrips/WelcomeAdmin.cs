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
    public partial class WelcomeAdmin : Form
    {
        int AdminId;
        String AdminName;
        public WelcomeAdmin(int id, String name)
        {
            AdminId = id;
            AdminName = name;
            InitializeComponent();
        }

        private void WelcomeAdmin_Load(object sender, EventArgs e)
        {
            String name = AdminName.Split(' ')[0];
            String welcome = "Welcom " + name + " to our Bus Trips Reservation System";
            txt_welcome.Text = welcome;
        }

        private void ManageScheduleAndSetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScheduleAndSets form = new ManageScheduleAndSets(AdminId, AdminName);
            form.Show();
            this.Hide();
        }

        private void ManagePaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePayments form = new ManagePayments(AdminId, AdminName);
            form.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }
    }
}
