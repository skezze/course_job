using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace course_job
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string pathlogdb = @"C:\coursejobDB\users.mdb";

            string path = @"C:\coursejobDB";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            BinaryFormatter formatter = new BinaryFormatter();
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            using (FileStream fs1 = new FileStream(pathlogdb, FileMode.OpenOrCreate))
            {
                try
                {
                    if (fs1.Length != 0)
                    {
                        Users[] users = (Users[])formatter.Deserialize(fs1);
                        for (int i = 0; i < users.Length; i++)
                        {
                            if ((loginFill.Text == users[i].Login) && (passwordFill.Text == users[i].Password) && (Convert.ToInt32(secretCode.Text) == users[i].SecretCode))
                            {
                                Password_check.password = users[i].Password;
                                this.Hide();
                                ForkForm fork = new ForkForm();
                                fork.Show();
                            }
                            else
                            {
                                label4.Visible = true;
                            }
                        }
                    }
                    else
                    {

                        MessageBox.Show("Пользователей в базе данных не найдено");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("неизвестная ошибка");
                }



            }
        }

        private void secretCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordFill_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginFill_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
