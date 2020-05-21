using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_job
{
    public partial class Edit : Form
    {
        public static bool returnAccesPassword = false;

       public int index;
        List<Clients> clients = new List<Clients>();
        string pathclientDB = @"C:\coursejobDB\clients.mdb";
        public Edit(int index)
        {
            InitializeComponent();
            using (BinaryReader reader = new BinaryReader(File.Open(pathclientDB, FileMode.Open)))
            {
               // index = 0;
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
            
            FIOField.Text = clients[index].FIO1;
            NOCField.Text = clients[index].CardNumber.ToString();
            comboBox1.Text = clients[index].Job;
            CostField.Text = clients[index].Cost.ToString();
            if (clients[index].CheckPayment == true)
                checkBox1.Checked = true;
            else
                checkBox2.Checked = true;
            Debt.Text = clients[index].Dolg.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            returnAccesPassword = false;
            PasswordCheck check = new PasswordCheck();

            check.ShowDialog();
            if (returnAccesPassword == true)
            {
                button1.Enabled = true;
                FIOField.Enabled = true;
                NOCField.Enabled = true;
                comboBox1.Enabled = true;
                CostField.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                Debt.Enabled = true;
                button2.Enabled = false;

            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                checkBox2.Checked = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clients temp = new Clients();
                if (checkBox1.Checked == true || checkBox2.Checked == true)
                {
                    if (Double.TryParse(NOCField.Text, out temp.cardNumber) &&
                        Double.TryParse(CostField.Text, out temp.cost) &&
                        Double.TryParse(Debt.Text, out temp.dolg))
                        if (temp.Cost > 0)
                            if (checkBox2.Checked == true && temp.Dolg != temp.Cost)
                                MessageBox.Show("Что-то не так");
                            else
                                using (BinaryWriter bf = new BinaryWriter(File.Open(pathclientDB, FileMode.Open)))
                                {
                                    if (temp.Dolg <=  temp.Cost && temp.Dolg > -1)
                                    {
                                        temp.FIO1 = FIOField.Text;
                                        temp.Job = comboBox1.Text;
                                        if (checkBox1.Checked == true)
                                            temp.CheckPayment = true;
                                        if (checkBox2.Checked == true)
                                            temp.CheckPayment = false;
                                        clients[index] = temp;
                                        for (int i = 0; i < clients.Count; i++)
                                        {
                                            bf.Write(clients[i].FIO1);
                                            bf.Write(clients[i].CardNumber);
                                            bf.Write(clients[i].Job);
                                            bf.Write(clients[i].Cost);
                                            bf.Write(clients[i].CheckPayment);
                                            bf.Write(clients[i].Dolg);
                                        }
                                        

                                        MessageBox.Show("данные отредактированы");


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
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                checkBox1.Checked = false;
        }
    }
}
