using Elearnin.Models;
using Elearnin.Properties;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class AllCatogory : Form
    {
        elearningContext obj;
        int id;
        int index;
        public AllCatogory()
        {
            InitializeComponent();
        }
        public AllCatogory(int id)
        {
            InitializeComponent();
            obj = new elearningContext();
            this.id = id;
        }

        void getdata()
        {
            var q1 = obj.Categories.ToList();
            dataGridView1.DataSource = q1;
            dataGridView1.Columns[0].Visible = false;
        }
        private void AllCatogory_Load(object sender, EventArgs e)
        {
            getdata();
            pictureBox6.Visible= false;
            pictureBox7.Visible= false;
        }
        void clear()
        {
            txtdesc.Text = " ";
            txtName.Text = " ";
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                index = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                var q1 = obj.Categories.Where(s => s.Id == index).SingleOrDefault();
                if (q1 != null)
                {
                    txtdesc.Text = q1.Description;
                    txtName.Text = q1.Name;
                }
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var q1 = obj.Categories.Where(s => s.Name == txtName.Text).SingleOrDefault();
            if (q1 != null)
            {
                MessageBox.Show("❌ A category with this name already exists");
                return;
            }
            Category category = new Category();
            category.Name = txtName.Text;
            category.Description = txtdesc.Text;
            obj.Categories.Add(category);

            obj.SaveChanges();
            clear();
            MessageBox.Show("✅ Category added successfully!");
           getdata();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var q1 = obj.Categories.Where(s => s.Id == index).FirstOrDefault();
            q1.Name = txtName.Text;
            q1.Description = txtdesc.Text;
            obj.SaveChanges();
            MessageBox.Show("✅ Category updated successfully!");
            clear();
            getdata();
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var q1 = obj.Categories.Where(s => s.Id == index);
            obj.Categories.Remove(q1.FirstOrDefault());
            obj.SaveChanges();
            MessageBox.Show("✅ Category deleted successfully!");
            clear();
            getdata();
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(id);
            admin.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             Profile profile = new Profile(id);
            profile.Show();
            this.Hide();

        }
    }
}
