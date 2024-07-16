using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared.Json;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace BusTrips
{
    public partial class Register : Form
    {
        String ordb = "Data Source = orcl; User Id = hr; Password = hr;";
        OracleConnection conn;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void btn_regist_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_mail.Text == "" || txt_password.Text == "")
                MessageBox.Show("Complete The Blanks!!!");
            else
            {
                // 2. Insert rows ( without using procedures )
                OracleCommand insertUser = new OracleCommand();
                insertUser.Connection = conn;
                insertUser.CommandText = "INSERT INTO Users  (UserId  , UserName , Email , UserPassword , UserType) " +
                    "VALUES (SEQUENCE_USERID.nextval, :username, :email, :password, :type)";
                insertUser.Parameters.Add("username", txt_name.Text);
                insertUser.Parameters.Add("email ", txt_mail.Text);
                insertUser.Parameters.Add("password ", txt_password.Text);
                insertUser.Parameters.Add("type ", "customer");

                int result = insertUser.ExecuteNonQuery();
                if (result != -1)
                    MessageBox.Show("Registration Successfully");
            
                txt_name.Text = "";
                txt_mail.Text = "";
                txt_password.Text = "";
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
