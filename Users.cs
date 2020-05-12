using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_job
{
    [Serializable]
    class Users
    {
        private string login = "";
        private string password = "";
        private int secretCode = 946732;
        
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public int SecretCode { get => secretCode; }
    }
}
