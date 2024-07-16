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
    public partial class Login : Form
    {
        String ordb = "Data Source = orcl; User Id = hr; Password = hr;";
        OracleConnection conn;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            txt_password.UseSystemPasswordChar = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            OracleCommand login = new OracleCommand();
            login.Connection = conn;
            login.CommandText = "SELECT UserId, UserName, UserType FROM Users WHERE Email = :email AND UserPassword = :password";
            login.CommandType = CommandType.Text;
            login.Parameters.Add("email", txt_email.Text);
            login.Parameters.Add("password", txt_password.Text);

            OracleDataReader dr = login.ExecuteReader();
            if (dr.Read())
            {
                if (dr[2].ToString() == "customer")
                {
                    WelcomeCustomer form = new WelcomeCustomer(Convert.ToInt32(dr[0]), dr[1].ToString());
                    form.Show();
                    this.Hide();
                }
                else if (dr[2].ToString() == "admin")
                {
                    WelcomeAdmin form = new WelcomeAdmin(Convert.ToInt32(dr[0]), dr[1].ToString());
                    form.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Wrong Credentials");
        }

        private void but_register_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
