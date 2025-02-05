using Elearnin.Models;
using Elearnin.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Elearnin.Forms
{
    public partial class Edit : Form
    {
        int id;
        elearningContext obj;
        public Edit()
        {
            InitializeComponent();
        }
        public Edit(int id)
        {
            InitializeComponent();
            this.id = id;
            obj = new elearningContext();

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
        }


        private void Edit_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            var data = obj.Users.Where(s => s.UserID == id).SingleOrDefault();
            if (data.Role == UserRole.Admin) st_button1.Visible = false;
            else ad_button1.Visible = false;
            txtage.Text = data.Age.ToString();
            txtemail.Text = data.Email;
            txtname.Text = data.FullName;
            txtphone.Text = data.Phone;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string namePattern = @"^[A-Za-z][A-Za-z0-9 ]*$";
            bool isValidName = Regex.IsMatch(txtname.Text, namePattern);
            if (!isValidName) { label9.Text = "❌ Invalid name format"; return; }
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]{5,}\.com$";
            bool isValidEmail = Regex.IsMatch(txtemail.Text, emailPattern);
            if (!isValidEmail)
            {
                label10.Text = "❌ Invalid email format";
                return;
            }

            var data = obj.Users.Where(s => s.UserID == id).SingleOrDefault();
            data.Email = txtemail.Text;
            data.FullName = txtname.Text;
            txtphone.Text = txtphone.Text;
            data.Age = int.Parse(txtage.Text);
            obj.SaveChanges();
            MessageBox.Show("✅ Your profile has been updated successfully!");
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(id);
            profile.Show();
            this.Hide();
        }
        void clear()
        {
           txtconf.Text  = txtnew.Text = texold.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var data = obj.Users.Where(s => s.UserID == id).SingleOrDefault();
            if (texold.Text != data.Password)
            {
                MessageBox.Show("❌ Incorrect old password. Please try again.");
                return;
            }
            else if (txtnew.Text == txtconf.Text)
            {
                data.Password = txtconf.Text;
                obj.SaveChanges();
                MessageBox.Show("Done");
                clear();
            }
            else MessageBox.Show("❌ Password and Confirm Password do not match");

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (txtnew.PasswordChar == '*')
            {
                txtnew.PasswordChar = '\0';
                texold.PasswordChar = '\0';
                txtconf.PasswordChar = '\0';

            }
            else
            {
                txtnew.PasswordChar = '*';
                texold.PasswordChar = '*';
                txtconf.PasswordChar = '*';
            }
        }

        private void ad_button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(id);
            admin.Show();
            this.Hide();
        }
    }
}
