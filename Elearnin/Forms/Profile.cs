using Elearnin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearnin.Forms
{
    public partial class Profile : Form
    {
        int id;
        elearningContext obj;
        public Profile()
        {
            InitializeComponent();
        }

        public Profile(int id)
        {
            InitializeComponent();
            obj = new elearningContext();
            this.id = id;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            var data = obj.Users.Where(s => s.UserID == id).SingleOrDefault();
            if(data.Role== UserRole.Admin) panel2.Visible = false;
            else panel1.Visible = false;
            name.Text = data.FullName;
            email.Text = data.Email;
            age.Text = data.Age.ToString();
            phone.Text = data.Phone;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(id);
            profile.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Home home = new Home(id);
            home.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(id);
            edit.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MyCouese myCouese = new MyCouese(id);
            myCouese.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Profile prof = new Profile(id);
            prof.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(id);
            admin.Show();
            this.Hide();
        }
    }
}
