using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_job
{[Serializable]
    class Clients
    {
       private string FIO = "";
        private double cardNumber = 0;
        private string job = "";
        private double cost = 0;
        private bool checkPayment = false;
        private double dolg = 0;

        public string FIO1 { get => FIO; set => FIO = value; }
        public double CardNumber { get => cardNumber; set => cardNumber = value; }
        public string Job { get => job; set => job = value; }
        public double Cost { get => cost; set => cost = value; }
        public bool CheckPayment { get => checkPayment; set => checkPayment = value; }
        public double Dolg { get => dolg; set => dolg = value; }
    }
}
