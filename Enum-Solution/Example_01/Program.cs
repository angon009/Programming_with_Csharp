using System;

namespace Example_01
{
    class Program
    {
        public enum LogStatus
        {
            LoggedIn,
            LoggedOut
        }
        static void Main(string[] args)
        {
            var login = LogInStatus();

            if(login == LogStatus.LoggedIn)
            {
                Console.WriteLine("Log In");
            }

            var logOut = LogOutStatus();

            if(logOut == LogStatus.LoggedOut)
            {
                Console.WriteLine("Log Out");
            }
        }

        public static LogStatus LogInStatus()
        {
            return LogStatus.LoggedIn;
        }

        public static LogStatus LogOutStatus()
        {
            return LogStatus.LoggedOut;
        }
    }
}
