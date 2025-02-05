using Elearnin.Properties;

namespace Elearnin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_Up sign_Up = new Sign_Up();
            sign_Up.Show();
            this.Hide();
        }
    }
}
