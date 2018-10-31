using ConsoleApp4.Domain;
using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        public static Dictionary<string, Users>  userDictionary = new Dictionary<string, Users>

                {
                    { "admin", new Users("admin", "secret", "Administrator") },
                    { "john", new Users("john", "secret", "Receptionist") }
                };
        //public static Dictionary<string, string> userDictionary2 = new Dictionary<string, string>

        //        {
        //            { "admin", "secret" },
        //            { "john", "secret" }
        //        };

        static void Main(string[] args)
        {
            
            LoginView loginView = new LoginView(userDictionary);

            var loggedUser = loginView.Display();

            if (loggedUser.Status == "Administrator")
            {
               AdminMeny adminMainView = new AdminMeny(); 
                
                adminMainView.AdminDisplay();

            }
            else if (loggedUser.Status == "Receptionist")
            {
                ReceptionistMeny recMeny = new ReceptionistMeny(userDictionary);

                recMeny.ReceptView();

            }






        }
    }
}
