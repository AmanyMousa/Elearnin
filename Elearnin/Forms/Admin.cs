using Elearnin.Models;
using Elearnin.Properties;
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
    public partial class Admin : Form
    {
        elearningContext obj;
        int id;
        int index;
        public Admin()
        {
            InitializeComponent();

        }
        public Admin(int id)
        {
            InitializeComponent();
            obj = new elearningContext();
            this.id = id;

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            var x = obj.Users.Where(s => s.UserID == id).SingleOrDefault();
            lab_name.Text = x.FullName;

        }



        private void button2_Click(object sender, EventArgs e)
        {

        }





        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Profile p = new Profile(id);
            p.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllCatogory allCatogory = new AllCatogory(id);
            allCatogory.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AllCourse a = new AllCourse(id);
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllUsers allUsers = new AllUsers(id);
            allUsers.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
