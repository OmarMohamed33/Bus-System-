using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace BusTrips
{
    public partial class ManageScheduleAndSets : Form
    {
        String ordb = "Data Source = orcl; User Id = hr; Password = hr;";
        OracleConnection conn;

        int AdminId;
        String AdminName;
        public ManageScheduleAndSets(int id, String name)
        {
            AdminId = id;
            AdminName = name;
            InitializeComponent();
        }

        private void ManageScheduleAndSets_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_price.Text == "" || txt_tdate.Text == "" || txt_locate.Text == "" || txt_expiry.Text == "" || txt_tickets.Text == "")
                MessageBox.Show("Complete The Blanks!!!");
            else
            {
                // 2. Insert rows ( without using procedures )
                OracleCommand insertTrip = new OracleCommand();
                insertTrip.Connection = conn;
                insertTrip.CommandText = "INSERT INTO Trips  (TripId, TripName, Price, TripDate, Locate, ExpiryDate, Tickets) " +
                    "VALUES (SEQUENCE_TripId.nextval, :tripname, :price, :tripdate, :locate, :expirydate, :tickets)";
                insertTrip.Parameters.Add("tripname", txt_name.Text);
                insertTrip.Parameters.Add("price ", txt_price.Text);
                insertTrip.Parameters.Add("tripdate ", txt_tdate.Text);
                insertTrip.Parameters.Add("Locate", txt_locate.Text);
                insertTrip.Parameters.Add("expirydate ", txt_expiry.Text);
                insertTrip.Parameters.Add("tickets ", txt_tickets.Text);

                int result = insertTrip.ExecuteNonQuery();
                if (result != -1)
                    MessageBox.Show("Insertion Successfully");
            
                txt_name.Text = "";
                txt_price.Text = "";
                txt_tdate.Text = "";
                txt_locate.Text = "";
                txt_expiry.Text = "";
                txt_tickets.Text = "";
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            WelcomeAdmin form = new WelcomeAdmin(AdminId, AdminName);
            form.Show();
            this.Hide();
        }

        private void ManageScheduleAndSets_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
