using ConsoleApp4.Domain;
using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        public static Dictionary<string, User> userDictionary = new Dictionary<string, User>

                {
                    { "admin", new User("admin", "secret", "Administrator") },
                    { "john", new User("john", "secret", "Receptionist") },
                    { "jake", new User("jake", "secret", "Receptionist") },
                    {  "jane",new User("jane", "secret", "Administrator") }
                };
       


        static void Main(string[] args)
        {

            LoginView loginView = new LoginView(userDictionary);
            var loggedUser = loginView.Display();

            if (loggedUser.Status == "Administrator")
            {
                var adminMainView = new AdminMenuView(userDictionary);
                adminMainView.Display();
            }
            else if (loggedUser.Status == "Receptionist")
            {
                var recMenu = new ReceptionistMenuView(userDictionary);
                recMenu.Display();
            }


        }
    }
}
