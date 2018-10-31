using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp4.Domain
{
    class LoginView
    {
        private readonly IDictionary<string, Users> _usersDictionary;

        bool notloggin = true;
        Users user = null;
        public LoginView(IDictionary<string, Users> usersDictionary)
        {
            _usersDictionary = usersDictionary;
        }

        public Users Display()
        {
            do
            {
                Console.Clear();
                Console.Write("Username____");
                var username = Console.ReadLine();

                Console.Write("Password____");
                var password = Console.ReadLine();

                Console.WriteLine("Is this  correct? (Y)es No");
                var answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {

                    if (_usersDictionary.ContainsKey(username) && _usersDictionary[username].Password == password)
                    {

                        user = _usersDictionary[username];
                        Thread.Sleep(2000);
                        notloggin = false;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                        notloggin = true;
                        Thread.Sleep(2000);
                    }
                }
                else
                    Console.WriteLine("Invalid username or password");


            } while (notloggin == true);
            return user;
        }
    }
}
