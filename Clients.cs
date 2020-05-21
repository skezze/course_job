using System;


namespace course_job
{
    class Clients
    {
        public string FIO = "";
        public double cardNumber = 0;
        public string job = "";
        public double cost = 0;
        public bool checkPayment = false;
        public double dolg = 0;

        public string FIO1 { get => FIO; set => FIO = value; }
        public double CardNumber { get => cardNumber; set => cardNumber = value; }
        public string Job { get => job; set => job = value; }
        public double Cost { get => cost; set => cost = value; }
        public bool CheckPayment { get => checkPayment; set => checkPayment = value; }
        public double Dolg { get => dolg; set => dolg = value; }
    }
}
