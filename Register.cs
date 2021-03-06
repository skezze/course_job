﻿using System;
using System.Collections.Generic;
using System.IO;

using System.Windows.Forms;

namespace course_job
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            string pathlogdb = @"C:\coursejobDB\users";
            string path = @"C:\coursejobDB";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            
            
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
           
            List<Users> users = new List<Users>();
            bool checkClear;
            using (FileStream file = new FileStream(pathlogdb, FileMode.OpenOrCreate))
            {
                if (file.Length != 0)
                {
                    checkClear = false;

                }
                else
                {
                    checkClear = true;
                }
                }
            if (checkClear == true)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(pathlogdb, FileMode.OpenOrCreate)))
                {

                    Users users2 = new Users();
                    if (Convert.ToInt32(secretCode.Text) == users2.SecretCode)
                    {
                        users2.Login = loginFill.Text;
                        users2.Password = passwordFill.Text;
                        users.Add(users2);
                        writer.Write(users2.Login);
                        writer.Write(users2.Password);
                        MessageBox.Show("Пользователь зарегистрирован");
                    }
                }
            }
            else {
                using (BinaryReader reader = new BinaryReader(File.Open(pathlogdb, FileMode.Open)))
                {

                    while (reader.PeekChar() > -1)
                    {
                        Users users1 = new Users();
                        users1.Login = reader.ReadString();
                        users1.Password = reader.ReadString();
                        users.Add(users1);
                    }
                
                }
                using (BinaryWriter writer = new BinaryWriter(File.Open(pathlogdb, FileMode.Append)))
                    {
                    int secret = 0;
                    if (Int32.TryParse(secretCode.Text, out secret))
                    {
                        if (secret == 946732)
                        {
                            int j = 0;
                            for (int i = 0; i < users.Count; i++)
                            {
                                if (users[i].Login == loginFill.Text)
                                    j++;
                            }
                            if (j == 0)
                            {
                                Users users4 = new Users();
                                users4.Login = loginFill.Text;
                                users4.Password = passwordFill.Text;
                                writer.Write(users4.Login);
                                writer.Write(users4.Password);
                                MessageBox.Show("Пользователь зарегистрирован");
                            }
                            else
                            {
                                label4.Visible = true;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный секретный код");
                    }
                }
            }
                
               
        }
    }
}
