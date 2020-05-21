﻿using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace course_job
{
    public partial class ForkForm : Form
    {
        
        public static bool returnAccesPassword = false;
       string pathclientDB = @"C:\coursejobDB\clients.mdb";
        List<Clients> clients = new List<Clients>();
        bool checkClear;

        

        public ForkForm()
        {
            InitializeComponent();
            label9.Visible = false;

            using (FileStream fs = new FileStream(pathclientDB, FileMode.OpenOrCreate))
            {
                if (fs.Length != 0)
                {
                    checkClear = false;
                }
                else
                {
                    checkClear = true;
                    label9.Visible = true;
                    listBox1.Visible = false;
                }
            }
            if(checkClear==false)
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
                
                string temp = "";
                temp = clients[i].FIO1.Substring(0, (clients[i].FIO1.Length<60)?(clients[i].FIO1.Length - 1):
                    59);
              
                for (int k = temp.Length-1; k < 60; k++)
                {
                    temp += "/";
                }
               // listBox1
                listBox1.Items.Add($"{temp}gdsh ");
            }
            
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
                        Double.TryParse(Debt.Text, out clients1[0].dolg))
                        if (clients1[0].Cost >= 0)
                            if (checkBox2.Checked == true && clients1[0].Dolg != clients1[0].Cost)
                                MessageBox.Show("Что-то не так");
                    else
                        using (BinaryWriter bf = new BinaryWriter(File.Open(pathclientDB,FileMode.Append)))
                        {
                            if (clients1[0].Dolg <= clients1[0].Cost&&clients1[0].Dolg>-1)
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

                                MessageBox.Show("клиент внесен в базу");
                                

                            }
                            else
                            {
                                MessageBox.Show("Проверьте на корректность поля с задолженностью и долгом");
                            }

                        }
                    else
                    {
                        MessageBox.Show("Неправильный ввод в некоторые поля");
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

                    ForkForm forkForm = new ForkForm();
                    forkForm.pathclientDB = openfile.FileName;
                    forkForm = new ForkForm();
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
                listBox1.Items.Clear();
                for (int i = 0; i < clients.Count; i++)
                {
                    listBox1.Items.Add(clients[i].FIO1);
                }
            }
            else
            {//fix find
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
                        listBox1.Items.Add($"{clients[i].FIO1,-30} {clients[i].Cost,-10} {clients[i].Dolg,-10} {clients[i].Job,-30}");
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
                        
                        listBox1.Items.Add($"{clients[i].FIO1,-30} {clients[i].Cost,-10} {clients[i].Dolg,-10} {clients[i].Job,-30}");
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
              //  tempPassword.Clients = clients[listBox1.SelectedIndex];
                Edit edit = new Edit(listBox1.SelectedIndex);
               // edit.index = ;
                edit.ShowDialog();
                this.Hide();
                ForkForm fork = new ForkForm();
                fork.Show();
            }
        }

      
    }
}

