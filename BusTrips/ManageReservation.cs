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
    public partial class ManageReservation : Form
    {
        String ordb = "Data Source = orcl; User Id = hr; Password = hr;";
        int CustomerId;
        String CustomerName;
        OracleConnection conn;
        public ManageReservation(int id, String name)
        {
            CustomerId = id;
            CustomerName = name;
            InitializeComponent();
        }

        private void ManageReservation_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand selecttrips = new OracleCommand();
            selecttrips.Connection = conn;
            selecttrips.CommandText = "SELECT TripName FROM Trips";

            OracleDataReader dr = selecttrips.ExecuteReader();
            while (dr.Read())
            {
                cmb_trips.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void cmb_trips_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand selecttickets = new OracleCommand();
            selecttickets.Connection = conn;
            selecttickets.CommandText = "SELECT Amount_Tickets FROM Reserve";

            OracleDataReader dr = selecttickets.ExecuteReader();
            while (dr.Read())
            {
                txt_tickets.Text = dr[3].ToString();
            }
            dr.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (cmb_trips.SelectedIndex < 0 || txt_edit_tickets.Text == "")
                MessageBox.Show("Change The Number of Tickets!!!");
            else
            {
                if (Convert.ToDouble(txt_edit_tickets.Text) >= Convert.ToDouble(txt_tickets.Text))
                    MessageBox.Show("Can't Reserve Number of Tickets more than the Reserved tickets");
                else
                {
                    OracleCommand update_amount = new OracleCommand();
                    update_amount.Connection = conn;
                    update_amount.CommandText = "update reserve set Amount_Tickets:a_t";
                    update_amount.Parameters.Add("a_t", txt_edit_tickets.Text);
                    int r = update_amount.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Update Occured");
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (cmb_trips.SelectedIndex < 0)
                MessageBox.Show("Choose Trip First!!!");
            else
            {
                OracleCommand cancel_reserve = new OracleCommand();
                cancel_reserve.Connection = conn;
                cancel_reserve.CommandText = "Delete from reserve where TripName =:TN";
                cancel_reserve.Parameters.Add("TN", cmb_trips.Text);
                int r = cancel_reserve.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Delete Occured");
                    cmb_trips.Items.RemoveAt(cmb_trips.SelectedIndex);
                    txt_tickets.Text = "";
                    txt_edit_tickets.Text = "";
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            WelcomeCustomer form = new WelcomeCustomer(CustomerId, CustomerName);
            form.Show();
            this.Hide();
        }

        private void ManageReservation_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
