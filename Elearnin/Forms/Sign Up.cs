using Elearnin.Models;
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

namespace Elearnin.Properties
{
    public partial class Sign_Up : Form
    {
        elearningContext obj;
        public Sign_Up()
        {
            InitializeComponent();
            obj = new elearningContext();
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label10.Text = "";
            label9.Text = "";
            label11.Text = "";
            int x = 0;
            string namePattern = @"^[A-Za-z][A-Za-z0-9 ]*$";
            bool isValidName = Regex.IsMatch(txt_name.Text, namePattern);
            if (!isValidName) { label9.Text = "❌ Invalid name format";  x = 1; }
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]{5,}\.com$";
            bool isValidEmail = Regex.IsMatch(txt_email.Text, emailPattern);
            if (!isValidEmail)
            {
                label10.Text = "❌ Invalid email format"; x = 1;
                
            }
            if (txt_pass.Text != txtconf.Text) { MessageBox.Show("❌ Password and Confirm Password do not match");  }
            if (txt_phone.Text.Length != 11) { label11.Text = "❌ Invalid Phone format"; x = 1;  }
            if (x == 1) return;
            Models.User user = new Models.User();
            user.FullName = txt_name.Text;
            user.Email = txt_email.Text;
            user.Phone = txt_phone.Text;
            user.Password = txt_pass?.Text;
            user.Age = int.Parse(txt_age.Text);
            user.Role = UserRole.Student;
            var q1 = obj.Users.Where(x => x.Email == user.Email).SingleOrDefault();
            if (q1 != null)
            {
                MessageBox.Show("You Already have account");
                return;
            }
            obj.Users.Add(user);
            obj.SaveChanges();
            MessageBox.Show("You can now log in");
            Login log = new Login();
            log.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '*')
            {
                txt_pass.PasswordChar = '\0';
                txtconf.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
                txtconf.PasswordChar = '*';
            }
        }
    }
}
