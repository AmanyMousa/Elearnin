using Dapper;
using Elearnin.Models;
using Elearnin.Properties;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Elearnin.Forms
{
    public partial class Home : Form
    {
        SqlConnection con;
        int id;

        public Home()
        {
            InitializeComponent();
            con = new SqlConnection("Server=.;Database=Elearning;Trusted_Connection=True; TrustServerCertificate=True");

        }

        public Home(int id)
        {
            InitializeComponent();

            this.id = id;
            con = new SqlConnection("Server=.;Database=Elearning;Trusted_Connection=True; TrustServerCertificate=True");


        }

        private void Home_Load(object sender, EventArgs e)
        {
            string q1 = "SELECT * FROM Users WHERE UserID = @id";
            var user = con.Query<Models.User>(q1, new { id }).FirstOrDefault();
            lab_name.Text = user.FullName;


            String q2 = "SELECT *FROM Categories ";

            com_cat.DataSource = con.Query<Models.Category>(q2).ToList();
            com_cat.ValueMember = "Id";
            com_cat.DisplayMember = "Name";

        }







        private void com_cat_SelectedValueChanged(object sender, EventArgs e)
        {
            if (com_cat.SelectedValue != null)
            {
                if (com_cat.SelectedValue is int ct)
                {

                    var query = @"SELECT  c.Title, u.FullName AS InstructorName FROM Courses c JOIN Users u ON c.InstructorId = u.UserID WHERE c.categoryId = @ct;";

                    var courses = con.Query(query, new { ct })
                        .Select(row => new
                        {

                            Title = row.Title,
                            InstructorName = row.InstructorName
                        }).ToList();



                    dataGridView1.DataSource = courses;


                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(id);
            profile.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                //MessageBox.Show(rowIndex.ToString());
                string Name = dataGridView1.Rows[rowIndex].Cells["Title"].Value?.ToString();
                var query = @"SELECT  * FROM Courses WHERE Courses.Title=@Name";

                var cour = con.Query(query, new { Name }).FirstOrDefault();
                
                if (cour != null)
                {
                    int courseid = cour.Id;
                    var q1 = @"SELECT  * FROM Subscriptions WHERE Subscriptions.CourseId=@Courseid And Subscriptions.UserId=@id ";
                    var Test = con.Query(q1, new { courseid, id }).FirstOrDefault();
                    
                    if (Test == null)
                    {

                        var q2 = @"INSERT INTO Subscriptions (UserId, courseId) VALUES (@id, @CourseId)";
                        con.Execute(q2, new { id, courseid });

                        MessageBox.Show("Subscription added successfully!");
                    }
                    else MessageBox.Show("you  added this befor!");


                }


            }
            else
            {
                MessageBox.Show("Please select a cell.");
            }
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
    }
}
