using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace course_job
{
    public partial class ForkForm : Form
    {
        Clients[] clients;
        string pathclientDB = @"C:\coursejobDB\clients.mdb";
        BinaryFormatter formatter = new BinaryFormatter();
        public ForkForm()
        {
            InitializeComponent();
           
            using (FileStream fs = new FileStream(pathclientDB, FileMode.OpenOrCreate))
            {
                clients = (Clients[])formatter.Deserialize(fs);
            }

        }


    private void ForkForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "DB.mdb";
            saveFile.Filter = "Файл базы данных|.mdb";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                //using (streamwriter)
            }
        }

        private void add_to_base_Click(object sender, EventArgs e)
        {
            Clients clients1 = new Clients();
            try
            {
                if(
                    
                    )
                using (FileStream fs1 = new FileStream(pathclientDB, FileMode.Append))
                {
                    

                }
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка сохранения обьекта в файл");
            }
            

        }
    }
}

