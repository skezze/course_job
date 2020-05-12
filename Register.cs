using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
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
                if (fs1.Length != 0)
                {
                    try
                    {
                        
                     Users[] users1 = (Users[])formatter.Deserialize(fs1);
                        Users[] users = new Users[users1.Length + 1];
                        users[users.Length-1]= new Users();
                        
                        for (int o=0; o < users1.Length;o++)
                        {
                            users[o] = users1[o];
                        }
                        
                        int secret = 0;
                        if (Int32.TryParse(secretCode.Text, out secret))
                        {
                            if (secret == 946732)
                            {
                                int j = 0;
                                for (int i = 0; i < users.Length-1; i++)
                                {
                                    if (users[i].Login == loginFill.Text)
                                        j++;
                                }
                                if (j == 0)
                                {
                                    users[users.Length-1].Login = loginFill.Text;
                                    users[users.Length-1].Password = passwordFill.Text;
                                    
                                    formatter.Serialize(fs1, users);
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


                    

                    catch (System.Runtime.Serialization.SerializationException)
                    {
                        MessageBox.Show("Ошибочка распаковки существующих аккаунтов");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибочка вышла");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Файл пуст");
                    try
                    {
                        Users[] users = new Users[1];
                        users[0] = new Users();
                        int secret = 0;
                        if (Int32.TryParse(secretCode.Text, out secret))
                        {
                            if (secret == 946732)
                            {
                                    users[0].Login = loginFill.Text;
                                    users[0].Password = passwordFill.Text;
                                    
                                    formatter.Serialize(fs1, users);
                                    MessageBox.Show("Пользователь зарегистрирован");
                                   
                                                         }
                        }
                        else
                        {
                            MessageBox.Show("Неверный секретный код");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Мда...");

                    }
                }
            }
        }
    }
}
