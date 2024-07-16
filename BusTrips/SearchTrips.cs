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
    public partial class SearchTrips : Form
    {
        // Using ODP.Net connected mode ( Oracle Connection and Oracle Command )
        String ordb = "Data Source = orcl; User Id = hr; Password = hr;";
        OracleConnection conn;
        
        String Tripname;
        int CustomerId;
        String CustomerName;
        
        public SearchTrips(int id, String name)
        {
            CustomerId = id;
            CustomerName = name;
            InitializeComponent();
        }

        private void SearchTrips_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand getTrips = new OracleCommand();
            getTrips.Connection = conn;
            getTrips.CommandText = "SELECT TripName FROM Trips";

            OracleDataReader dr = getTrips.ExecuteReader();
            while (dr.Read())
            {
                Tripname = cmb_trips.Items.Add(dr[0]).ToString();
            }
            dr.Close();
        }

        private void cmb_trips_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_trips.SelectedIndex < 0)
                MessageBox.Show("Change The Number of Tickets!!!");
            else
            {
                // 3. Select ONE row from DB using stored Procedures (without using sysRefCursor)
                OracleCommand getTripDetails = new OracleCommand();
                getTripDetails.Connection = conn;
                getTripDetails.CommandText = "TripsDetails";
                getTripDetails.CommandType = CommandType.StoredProcedure;
                getTripDetails.Parameters.Add("TName", Tripname[cmb_trips.SelectedIndex]);
                getTripDetails.Parameters.Add("TripName", OracleDbType.Varchar2, ParameterDirection.Output);
                getTripDetails.Parameters.Add("Price", OracleDbType.Double, ParameterDirection.Output);
                getTripDetails.Parameters.Add("TripDate", OracleDbType.Date, ParameterDirection.Output);
                getTripDetails.Parameters.Add("ExpiryDate", OracleDbType.Date, ParameterDirection.Output);
                getTripDetails.Parameters.Add("Locate", OracleDbType.Varchar2, ParameterDirection.Output);
                getTripDetails.Parameters.Add("Tickets", OracleDbType.Int32, ParameterDirection.Output);

                getTripDetails.ExecuteNonQuery();

                txt_name.Text = getTripDetails.Parameters["TripName"].Value.ToString();
                txt_price.Text = getTripDetails.Parameters["Price"].Value.ToString();
                txt_trip_date.Text = getTripDetails.Parameters["TripDate"].Value.ToString();
                txt_expiry_date.Text = getTripDetails.Parameters["ExpiryDate"].Value.ToString();
                txt_location.Text = getTripDetails.Parameters["Locate"].Value.ToString();
                txt_total_tickets.Text = getTripDetails.Parameters["Tickets"].Value.ToString();
            }
        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            if (cmb_trips.SelectedIndex < 0 || txt_choose_tickets.Text == "")
                MessageBox.Show("Choose Tickets!!!");
            else
            {
                if (Convert.ToDouble(txt_choose_tickets.Text) >= Convert.ToDouble(txt_total_tickets.Text))
                    MessageBox.Show("Can't reserve number of tickets more than the total tickets");
                else
                {
                    // 2. Insert rows ( without using procedures )
                    OracleCommand newReserve = new OracleCommand();
                    newReserve.Connection = conn;
                    newReserve.CommandText = "INSERT INTO Reserve (ResesrveId , TripName, CustomerName, Amount_Tickets, Price, Status) " +
                        "VALUES (Sequence_ReserveId.nextval, :tripname, :customername , :amounttickets, :price, :status)";
                    newReserve.Parameters.Add("tripname", cmb_trips.SelectedIndex.ToString());
                    newReserve.Parameters.Add("customername ", CustomerName);
                    newReserve.Parameters.Add("amounttickets", txt_choose_tickets.Text);
                    newReserve.Parameters.Add("price", Convert.ToDouble(txt_price.Text));
                    newReserve.Parameters.Add("status", "pending");

                    int result = newReserve.ExecuteNonQuery();
                    if (result != -1)
                    {
                        MessageBox.Show("Reserved Successfully");
                    }
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            WelcomeCustomer form = new WelcomeCustomer(CustomerId, CustomerName);
            form.Show();
            this.Hide();
        }

        private void SearchTrips_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
