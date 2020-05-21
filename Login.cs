using System;
using System.Collections.Generic;
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
            bool checkClear;
            using (FileStream fs1 = new FileStream(pathlogdb, FileMode.OpenOrCreate))
            {
                if (fs1.Length == 0)
                    checkClear = true;
                else
                    checkClear = false;
            
            }
            if (checkClear == true)
            {
                MessageBox.Show("Пользователей в базе данных не найдено");
            }
            else
            {
                List<Users> users = new List<Users>();
                int secret;
                Int32.TryParse(secretCode.Text,out secret);
                if (secret == 946732)
                    using (BinaryReader reader = new BinaryReader(File.Open(pathlogdb, FileMode.Open)))
                    {

                        while (reader.PeekChar() > -1)
                        {

                            Users users1 = new Users();
                            users1.Login = reader.ReadString();
                            users1.Password = reader.ReadString();
                            users.Add(users1);
                            
                        }
                        for (int i = 0; i < users.Count; i++)
                        {
                            if (loginFill.Text == users[i].Login && passwordFill.Text == users[i].Password)
                            {
                                tempPassword.Password = passwordFill.Text;
                                this.Hide();

                                ForkForm forkForm = new ForkForm();
                                
                                forkForm.Show();
                            }

                        }
                        label4.Visible = true;
                    }
                else
                    label4.Visible = true;
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
