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
    public partial class ManagePayments : Form
    {
        // Using ODP.Net Disconnected mode (OracleDataAdapter and Dataset)
        OracleDataAdapter adapter;
        DataSet ds;
        OracleCommandBuilder builder;

        //////////
        String ordb = "Data Source = orcl; User Id = hr; Password = hr;";
        int AdminId;
        String AdminName;
        OracleConnection conn;

        public ManagePayments(int id, String name)
        {
            AdminId = id;
            AdminName = name;
            InitializeComponent();
        }

        private void ManagePayments_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand getTrips = new OracleCommand();
            getTrips.Connection = conn;
            getTrips.CommandText = "SELECT TripName FROM Trips";

            OracleDataReader dr = getTrips.ExecuteReader();
            while (dr.Read())
            {
                cmb_trips.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void cmb_trips_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Select certain rows for a given value entered by the user on the form
            String constr = "Data Source = orcl; User Id = hr; Password = hr;";
            String comstr = @"SELECT CustomerName, Amount_Tickets, status
                              FROM Reserve WHERE TripName =:TN";
            adapter = new OracleDataAdapter(comstr, constr);
            adapter.SelectCommand.Parameters.Add("TN", cmb_trips.SelectedIndex.ToString());
            ds = new DataSet();
            adapter.Fill(ds);
            dgv_bids.DataSource = ds.Tables[0];
            dgv_bids.AllowUserToDeleteRows = false;
            dgv_bids.AllowUserToAddRows = false;
            dgv_bids.Columns[0].ReadOnly = true;
            dgv_bids.Columns[1].ReadOnly = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (cmb_trips.SelectedIndex < 0)
                MessageBox.Show("Change The Number of Tickets!!!");
            else
            {
                // 2. Update using oracle command builder
                builder = new OracleCommandBuilder(adapter);
                adapter.Update(ds.Tables[2]);
                MessageBox.Show("Updated");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            WelcomeAdmin form = new WelcomeAdmin(AdminId, AdminName);
            form.Show();
            this.Hide();
        }

        private void ManagePayments_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
