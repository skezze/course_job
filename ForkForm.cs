using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace course_job
{
    public partial class ForkForm : Form
    {
        
        public static bool returnAccesPassword = false;
       public static string pathclientDB = @"C:\coursejobDB\clients";
        List<Clients> clients = new List<Clients>();
        bool checkClear;
        List<int> numberSave = new List<int>();
        

        public ForkForm()
        {
            InitializeComponent();
            string pathhelp = @"C:\coursejobDB\help\help.html";
            if (!File.Exists(pathhelp))
            {
                toolTip1.SetToolTip(label9,"файла справки не существует");
            }
            else
            {
                HelpProvider helpProvider = new HelpProvider();
                helpProvider.HelpNamespace = pathhelp;
                helpProvider.SetShowHelp(this, true);
            }



            using (FileStream fs = new FileStream(pathclientDB, FileMode.OpenOrCreate))
            {
                if (fs.Length != 0)
                {
                    checkClear = false;
                }
                else
                {
                    checkClear = true;
                    
                }
            }
            if (checkClear == false)
                try
                {
                    using (BinaryReader reader = new BinaryReader(File.Open(pathclientDB, FileMode.Open)))
                    {
                        while (reader.PeekChar() > -1)
                        {
                            Clients clients1 = new Clients();
                            clients1.FIO1 = reader.ReadString();
                            clients1.CardNumber = reader.ReadDouble();
                            clients1.Job = reader.ReadString();
                            clients1.Cost = reader.ReadDouble();
                            clients1.CheckPayment = reader.ReadBoolean();
                            clients1.Dolg = reader.ReadDouble();
                            clients.Add(clients1);
                        }
                    }
                    for (int i = 0; i < clients.Count; i++)
                    {
                        listBox1.Items.Add($"{clients[i].FIO1.PadRight(50) + clients[i].Cost.ToString().PadRight(10) + clients[i].Dolg.ToString().PadRight(10)}");
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то не так с файлом базы данных");
                }
        }

        private void HelpProvider2_Disposed(object sender, EventArgs e)
        {
            MessageBox.Show("Файла справки нет");
        }

        private void ForkForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path1 = @"C:\coursejobDB\clients.mdb";
                    File.Copy(path1, saveFile.FileName);
                    MessageBox.Show("Файл создан");
                }
                catch (Exception)
                {
                    MessageBox.Show("Файл не создан");
                }
                
            }
        }

        private void add_to_base_Click(object sender, EventArgs e)
        {
            List<Clients>clients1 = new List<Clients>();
            Clients client = new Clients();
            clients1.Add(client);
            try
            {
                if (checkBox1.Checked == true || checkBox2.Checked == true)
                {
                    if (Double.TryParse(NOCField.Text, out clients1[0].cardNumber) &&
                        Double.TryParse(CostField.Text, out clients1[0].cost) &&
                        Double.TryParse(Debt.Text, out clients1[0].dolg)&&
                        FIOField.Text.Length>0&&comboBox1.Text.Length>0)
                        if (clients1[0].Cost > 0)
                            if (checkBox2.Checked == true && clients1[0].Dolg != clients1[0].Cost)
                                MessageBox.Show("Что-то не так с задолженностью, отметкой об оплате или долгом");
                            else
                                using (BinaryWriter bf = new BinaryWriter(File.Open(pathclientDB, FileMode.Append)))
                                {
                                    if (clients1[0].Dolg <= clients1[0].Cost && clients1[0].Dolg > -1)
                                    {
                                        clients1[0].FIO1 = FIOField.Text;
                                        clients1[0].Job = comboBox1.Text;
                                        if (checkBox1.Checked == true)
                                            clients1[0].CheckPayment = true;
                                        if (checkBox2.Checked == true)
                                            clients1[0].CheckPayment = false;
                                        bf.Write(clients1[0].FIO1);
                                        bf.Write(clients1[0].CardNumber);
                                        bf.Write(clients1[0].Job);
                                        bf.Write(clients1[0].Cost);
                                        bf.Write(clients1[0].CheckPayment);
                                        bf.Write(clients1[0].Dolg);

                                        MessageBox.Show("Клиент внесен в базу");


                                    }
                                    else
                                    {
                                        MessageBox.Show("Проверьте на корректность поля с задолженностью и долгом");
                                    }

                                }
                        else
                        {
                            MessageBox.Show("Стоимость услуг должна быть больше 0");
                        }
                    else {
                        MessageBox.Show("Неправильный или неполный ввод в поля");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите отметку об оплате");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка сохранения обьекта в файл");
            }
            finally
            {
                this.Hide();
                ForkForm forkForm1 = new ForkForm();
                forkForm1.Show();
            }

        }

        private void clear_but_Click(object sender, EventArgs e)
        {
            FIOField.Clear();
            NOCField.Clear();
            CostField.Clear();
            Debt.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.Text="";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                checkBox1.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                try
                {                 
                    this.Hide();
                    ForkForm.pathclientDB = openfile.FileName;
                    ForkForm forkForm = new ForkForm();
                    //forkForm.pathclientDB =
                    
                    forkForm.Show();
                    MessageBox.Show("Файл базы данных загружен");
                }
                catch (Exception)
                {
                    MessageBox.Show("Файл не загружен");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                numberSave.Clear();
                listBox1.Items.Clear();
                for (int i = 0; i < clients.Count; i++)
                {
                    listBox1.Items.Add(clients[i].FIO1.PadRight(50) + clients[i].Cost.ToString().PadRight(10) + clients[i].Dolg.ToString().PadRight(10));
                }
            }
            else
            {
                listBox1.Items.Clear();

                for (int i = 0; i < clients.Count; i++)
                {
                    
                    Double parseCardNumber = 0,parsecost=0,parsedolg=0;
                    //пытаемся спарсить число, если оно введено, иначе -1
                    if (!Double.TryParse(textBox1.Text, out parsecost))
                        parsecost = -1;
                    if (!Double.TryParse(textBox1.Text, out parsedolg))
                        parsedolg = -1;
                    if (!Double.TryParse(textBox1.Text, out parseCardNumber))
                        parseCardNumber = -1;
                    if (clients[i].FIO1.Contains(textBox1.Text)||
                        clients[i].Job.Contains(textBox1.Text)||
                        clients[i].CardNumber==parseCardNumber||
                        clients[i].Cost==parsecost||
                        clients[i].Dolg ==parsedolg)
                    {
                        listBox1.Items.Add($"{clients[i].FIO1.PadRight(50) + clients[i].Cost.ToString().PadRight(10) + clients[i].Dolg.ToString().PadRight(10)}");
                        numberSave.Add(i);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double alldebt = 0;
            double selectdebt = 0;
        for (int i = 0; i < clients.Count; i++)
            {
                alldebt += clients[i].Dolg;
                if (textBox2.Text == clients[i].Job)
                {
                    selectdebt += clients[i].Dolg;
                    

                }
            }
            MessageBox.Show($"По вашему запросу задолженность {selectdebt}. \nОбщая задолженность {alldebt}");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            returnAccesPassword = false;
            PasswordCheck check = new PasswordCheck();
           
            check.ShowDialog();
            if (returnAccesPassword == true)
            { 
                listBox1.Items.Clear();
                

                for (int i = 0; i < clients.Count;)
                { 
                    if (clients[i].Dolg == 0)
                    {
                        clients.RemoveAt(i);
                    }
                    else
                    {
                        
                        listBox1.Items.Add($"{clients[i].FIO1.PadRight(50) + clients[i].Cost.ToString().PadRight(10) + clients[i].Dolg.ToString().PadRight(10)}");
                        i++;
                    }
                
                }
                File.Delete(pathclientDB);
                using (BinaryWriter bf = new BinaryWriter(File.Open(pathclientDB, FileMode.CreateNew)))
                {
                    for (int i = 0; i < clients.Count; i++)
                    {
                        bf.Write(clients[i].FIO1);
                        bf.Write(clients[i].CardNumber);
                        bf.Write(clients[i].Job);
                        bf.Write(clients[i].Cost);
                        bf.Write(clients[i].CheckPayment);
                        bf.Write(clients[i].Dolg);
                    }
                   
                }
            }
            
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
             if (listBox1.SelectedIndex > -1)
            {
                if (numberSave.Count == 0)
                {
                    Edit.pathclientDB = pathclientDB;
                    Edit edit = new Edit(listBox1.SelectedIndex);
                    edit.ShowDialog();
                    this.Hide();
                    ForkForm fork = new ForkForm();
                    fork.Show();
                }
                else 
                {
                            Edit edit = new Edit(numberSave[listBox1.SelectedIndex]);
                            edit.ShowDialog();
                            this.Hide();
                            ForkForm fork = new ForkForm();
                            fork.Show();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Help help = new Help();
            //help.Show();
        }
    }
}

