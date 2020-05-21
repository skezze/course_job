
namespace course_job
{
   abstract class tempPassword
    {
        private static string password = "";
        //private static Clients clients = new Clients();


        public static string Password { get => password; set => password = value; }
        //public static Clients Clients { get => clients; set => clients = value; }
    }
}
