using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Domain
{
    class ReceptionistMenuView
    {
        private IDictionary<string, User> _users { get; }
    
        public ReceptionistMenuView(IDictionary<string, User> users)
        {
            _users = users;
        }


        public void Display()
        {
            while (true)
            {
                Console.WriteLine("1. List of users");
                Console.WriteLine("2. Search");
                Console.WriteLine("3. Exite");

                var recChoice = Console.ReadKey().Key;

                switch (recChoice)
                {
                    case ConsoleKey.D1:
                        var sl = new ShowListOfUsersView(_users);
                        sl.Display();

                        Console.WriteLine(" 2. Go to previous menu.");
                        string choice = Console.ReadLine();
                        if (choice == "2")
                        {

                            var rm = new ReceptionistMenuView(_users);
                               
                            rm.Display();
                          
                        }
                        break;
                    case ConsoleKey.D2:
                        var su = new SearchUserView(_users);
                        List<User> lu = su.Display();
                        foreach (var item in lu)
                        {
                            Console.WriteLine("Name: " + item.Username);
                        }

                        break;

                    case ConsoleKey.D3:

                        return;
                }
            }        
        }
    }
}
