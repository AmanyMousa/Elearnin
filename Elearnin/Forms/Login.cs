using Dapper;
using Elearnin.Forms;
using Elearnin.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearnin.Properties
{
    public partial class Login : Form
    {
        SqlConnection con;

        int id;
        public Login()
        {
            InitializeComponent();
            con = new SqlConnection("Server=.;Database=Elearning;Trusted_Connection=True; TrustServerCertificate=True");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up sign_Up = new Sign_Up();
            sign_Up.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
            string email = txt_email.Text;
            string pass = txt_Password.Text;
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]{5,}\.com$";
            bool isValidEmail = Regex.IsMatch(email, emailPattern);
            if (!isValidEmail)
            {
                label5.Text = "❌ Invalid email format";
                return;
            }
            if (string.IsNullOrWhiteSpace(pass))
            {
                label6.Text = "❌ Please enter a password";
                return;
            }

            string q1 = "SELECT * FROM Users WHERE Email = @email AND Password = @pass";
            var user = con.Query<User>(q1, new { email, pass }).FirstOrDefault();

            if (user != null)
            {
                if (user.Role == UserRole.Student)
                {
                    Home home = new Home(user.UserID);
                    home.Show();
                    this.Hide();
                }
                else if (user.Role == UserRole.Admin)
                {
                    Admin admin = new Admin(user.UserID);
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password");
            }
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txt_Password.PasswordChar == '*')
            {
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
