using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Domain
{
    class AdminMenuView
    {
        private IDictionary<string, User> _users;

        public AdminMenuView(IDictionary<string, User> users)
        {
            _users = users;
        }

        public void Display()
        {
            while (true)
            {
                Console.WriteLine("1. Manage user");
                Console.WriteLine("2. Exit");

                var adminChoice = Console.ReadLine();

                switch (adminChoice)
                {
                    case "1":
                        var mu = new ManageUserView(_users);
                        mu.Display();
                        break;

                    case "2":
                        return;
                }
            }
        }
    }
}
