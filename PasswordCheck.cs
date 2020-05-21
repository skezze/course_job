using System;
using System.Windows.Forms;

namespace course_job
{
    public partial class PasswordCheck : Form
    {
        private static string password = tempPassword.Password;
        public PasswordCheck()
        {
            InitializeComponent();
           
        } 
    

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == password)
            {
                ForkForm.returnAccesPassword = true;
                Edit.returnAccesPassword = true;
                MessageBox.Show("Пароль верный");
                this.Hide();
            }
            else
                label2.Visible = true;
        }
    }
}
