using Elearnin.Models;
using Elearnin.Properties;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Elearnin.Forms
{
    public partial class AllUsers : Form
    {
        int id;
        elearningContext obj;
        int index;
        public AllUsers()
        {
            InitializeComponent();
        }
        public AllUsers(int id)
        {
            InitializeComponent();
            this.id = id;
            obj = new elearningContext();
        }

        private void AllUsers_Load(object sender, EventArgs e)
        {
            com_user.DataSource = Enum.GetValues(typeof(UserRole));
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            panel1.Visible = false;
            linkLabel2.Visible = false;
        }
        void clear()
        {
            texName.Text = "";
            txtphone.Text = "";
            txtemail.Text = "";
            txtage.Text = "";
            txtconf.Text = "";
            txtnew.Text = "";
            texold.Text = "";
            conf.Text = "";
            pass.Text = "";
        }
        private void com_user_SelectedValueChanged(object sender, EventArgs e)
        {
            if (com_user.SelectedValue != null)
            {
                clear();

                getdata();
            }
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;

        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                index = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                var q1 = obj.Users.Where(s => s.UserID == index).SingleOrDefault();
                if (q1 != null)
                {
                    txtage.Text = q1.Age.ToString();
                    txtemail.Text = q1.Email;
                    texName.Text = q1.FullName;
                    txtphone.Text = q1.Phone;
                }
                linkLabel2.Visible = true;
                panel3.Visible = false;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (panel1.Visible == true) panel1.Visible = false;

            else panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var q1 = obj.Users.Where(s => s.UserID == index).SingleOrDefault();
            if (q1 != null)
            {
                if (q1.Password != texold.Text) MessageBox.Show("Please enter old number right ");
                else if (txtnew.Text == txtconf.Text)
                {
                    q1.Password = txtconf.Text;
                    obj.SaveChanges();
                    MessageBox.Show("done");
                    clear();
                }
                else MessageBox.Show("❌ Password and Confirm Password do not match");
            }
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var q1 = obj.Users.Where(s => s.Email == txtemail.Text).SingleOrDefault();
            if (q1 != null)
            {
                MessageBox.Show("❌ this user already exists");
                return;
            }
            Models.User user = new Models.User();
            user.FullName = texName.Text;
            user.Phone = txtphone.Text;
            user.Email = txtemail.Text;
            user.Age = int.Parse(txtage.Text);
            UserRole selectedRole;
            if (Enum.TryParse(com_user.SelectedValue.ToString(), out selectedRole))
                user.Role = selectedRole;
            if (conf.Text != pass.Text) MessageBox.Show("❌ Password and Confirm Password do not match");
            else
            {
                user.Password = pass.Text;
                obj.Users.Add(user);
                obj.SaveChanges();
                MessageBox.Show("✅ User registered successfully!");

                var q = obj.Users.Where(s => s.Role == selectedRole).Select(s => new { s.UserID, s.FullName, s.Email, s.Age, s.Phone }).ToList();
                dataGridView1.DataSource = q;
                dataGridView1.Columns["UserID"].Visible = false;

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var q1 = obj.Users.Where(s => s.UserID == index).SingleOrDefault();
            if (q1 != null)
            {
                q1.FullName = texName.Text;
                q1.Phone = txtphone.Text;
                q1.Email = txtemail.Text;
                q1.Age = int.Parse(txtage.Text);
            }
            obj.SaveChanges();
            MessageBox.Show("✅ User details updated successfully!");
            clear();
            panel1.Visible = false;
            linkLabel2.Visible = false;
            panel3.Visible = true;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            getdata();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var q1 = obj.Users.Where(s => s.UserID == index).SingleOrDefault();
            var q2=obj.Subscriptions.Where(s=>s.UserId== index).ToList();
            if (q2 != null) {
                foreach (var sub in q2)
                {
                    obj.Subscriptions.Remove(sub);
                    obj.SaveChanges();
                }
                
           
            }
            if (q1 != null)
            {

                obj.Users.Remove(q1);
                obj.SaveChanges();
                MessageBox.Show("✅ User deleted successfully!");
            }
            clear();
            panel1.Visible = false;
            linkLabel2.Visible = false;
            panel3.Visible = true;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            getdata();

        }
        void getdata()
        {
            UserRole selectedRole;
            if (Enum.TryParse(com_user.SelectedValue.ToString(), out selectedRole))
            {
                var q = obj.Users.Where(s => s.Role == selectedRole).Select(s => new { s.UserID, s.FullName, s.Email, s.Age, s.Phone }).ToList();
                dataGridView1.DataSource = q;
                dataGridView1.Columns["UserID"].Visible = false;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (pass.PasswordChar == '*')
            {
                pass.PasswordChar = '\0';
                conf.PasswordChar = '\0';
            }
            else
            {
                pass.PasswordChar = '*';
                conf.PasswordChar = '*';

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Admin admin = new Admin(id);
            admin.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(id);
            admin.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
