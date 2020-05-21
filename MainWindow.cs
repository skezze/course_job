using System;
using System.Windows.Forms;


namespace course_job
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonToLoginForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void buttonToRegForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
