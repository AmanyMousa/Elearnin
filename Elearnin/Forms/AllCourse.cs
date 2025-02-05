using Elearnin.Models;
using Elearnin.Properties;
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
using System.Xml.Linq;

namespace Elearnin.Forms
{
    public partial class AllCourse : Form
    {
        int id;
        int index;
        elearningContext obj;
        public AllCourse()
        {
            InitializeComponent();
        }
        public AllCourse(int id)
        {
            InitializeComponent();
            this.id = id;
            obj = new elearningContext();
        }
        private void labemail_Click(object sender, EventArgs e)
        {

        }

        private void AllCourse_Load(object sender, EventArgs e)
        {
            var q1 = obj.Categories.ToList();
            com_cat.DataSource = q1;
            com_cat.ValueMember = "Id";
            com_cat.DisplayMember = "Name";

            var q2 = obj.Users.Where(s => s.Role == UserRole.Instructor).ToList();
            comboBox1.DataSource = q2;
            comboBox1.ValueMember = "UserID";
            comboBox1.DisplayMember = "FullName";
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }
        private void com_cat_SelectedValueChanged(object sender, EventArgs e)
        {

            if (com_cat.SelectedValue != null)
            {
                ret();
            }
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }

        void ret()
        {
            if (com_cat.SelectedValue is int ct)
            {
                var q1 = obj.Courses.Where(s => s.categoryId == ct).Select(s => new { s.Id, s.Title, s.Description, s.Duration, Instructor_Name = s.Instructor.FullName }).ToList();
                dataGridView1.DataSource = q1;
                dataGridView1.Columns[0].Visible = false;

            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var q1 = obj.Courses.Where(s => s.Title == txtTitel.Text).SingleOrDefault();
            if (q1 != null)
            {
                MessageBox.Show("❌ A Course with this name already exists");
                return;
            }
            Course c = new Course();
            c.Title = txtTitel.Text;
            c.Duration = int.Parse(txtdura.Text);
            c.Description = txtdesc.Text;
            c.InstructorId = (int)comboBox1.SelectedValue;
            c.categoryId = (int)com_cat.SelectedValue;
            obj.Courses.Add(c);
            obj.SaveChanges();
            MessageBox.Show("✅ Course added successfully!");
            ret();
            clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                index = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                var q = obj.Courses.Where(s => s.Id == index).SingleOrDefault();
                txtdesc.Text = q.Description;
                txtTitel.Text = q.Title;
                txtdura.Text = q.Duration.ToString();
                comboBox1.SelectedValue = q.InstructorId;
            }
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var q = obj.Courses.Where(s => s.Id == index).SingleOrDefault();
            q.Description = txtdesc.Text;
            q.Title = txtTitel.Text;
            q.Duration = int.Parse(txtdura.Text);
            q.InstructorId = (int)comboBox1.SelectedValue;
            obj.SaveChanges();
            MessageBox.Show("✅ Course updated successfully!");
            ret();
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            clear();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var q = obj.Courses.Where(s => s.Id == index).SingleOrDefault();
            obj.Courses.Remove(q);
            obj.SaveChanges();
            MessageBox.Show("✅ Course deleted successfully!");
            ret();
            clear();
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

        }
        void clear()
        {
            txtTitel.Text = txtdura.Text = txtdesc.Text = " ";

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Profile prof = new Profile(id);
            prof.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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
