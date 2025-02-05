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

namespace Elearnin.Forms
{
    public partial class MyCouese : Form
    {
        int id;
        elearningContext obj;

        public MyCouese()
        {
            InitializeComponent();
        }
        public MyCouese(int id)
        {
            InitializeComponent();
            this.id = id;
            obj = new elearningContext();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MyCouese myCouese = new MyCouese(id);
            myCouese.Show();
            this.Hide();
        }
        private void com_cat_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (com_cat.SelectedValue != null)
            {
                
                    ret();
                
            }
        }

        void ret()
        {
            if (com_cat.SelectedValue is int ct)
            {
                var q1 = obj.Categories.Where(s => s.Id == ct).SingleOrDefault();
                var q2 = obj.Subscriptions.Include(s => s.Course).ThenInclude(c => c.category).Where(s => s.Course.categoryId == q1.Id&&s.UserId==id)
                 .Select(s => new { name_course = s.Course.Title }).Distinct() .ToList();
                dataGridView1.DataSource = q2;

            }

        }
        private void MyCouese_Load(object sender, EventArgs e)
        {
            var q1 = obj.Categories.ToList();
            com_cat.DataSource = q1;
            com_cat.ValueMember = "Id";
            com_cat.DisplayMember = "Name";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                string Name = dataGridView1.Rows[rowIndex].Cells[0].Value?.ToString();
                var q1=obj.Courses.Where(s=>s.Title == Name).SingleOrDefault(); 
                var q2=obj.Subscriptions.Where(s=>s.UserId==id && s.CourseId==q1.Id).SingleOrDefault();
                obj.Subscriptions.Remove(q2);
                obj.SaveChanges();
                MessageBox.Show("✅ Subscription removed successfully!");
                ret();

            }
        }
    }
}
