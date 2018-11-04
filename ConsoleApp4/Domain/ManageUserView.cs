using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Domain
{
    class ManageUserView 
    {

        private readonly IDictionary<string, User> _usersDictionary;

        public ManageUserView(IDictionary<string, User> usersDictionary)
        {
            _usersDictionary = usersDictionary;
        }

        public void Display()
        {
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Search user");
            Console.WriteLine("3. Exit");

            var manChoice = Console.ReadKey().Key;

            switch (manChoice)
            {
                case ConsoleKey.D1:

                    AddUsersView adu = new AddUsersView(_usersDictionary);
                    adu.AddUser();

                    Console.ReadLine();
                    break;

                case ConsoleKey.D2:
                    var su = new SearchUserView(_usersDictionary);
                    List<User> lu = su.Display();
                    foreach (var item in lu)
                    {
                        Console.WriteLine("Name:  {0} ", item.Username);
                        Console.ReadLine();
                        Console.WriteLine("(D)elete.(N)o");
                        var cho = Console.ReadKey().Key;

                        switch (cho)
                        {
                            case ConsoleKey.D:

                                Console.WriteLine("Delete user {0} ? _ (Y)es or (N)o", item.Username);
                                var yesorno = Console.ReadKey().Key;

                                if (yesorno == ConsoleKey.Y)
                                {
                                    RemoveUserView ru = new RemoveUserView(_usersDictionary);
                                    ru.Display();

                                }
                                else
                                    break;
                                return;
                            case ConsoleKey.N:
                                return;
                                
                        }
                    }
                    return;

                case ConsoleKey.D3:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
