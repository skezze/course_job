using System;

namespace course_job
{
    
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
