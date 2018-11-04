using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Domain
{
    public class RemoveUserView
    {
        private IDictionary<string, User> _users;

        public RemoveUserView(IDictionary<string, User> users)
        {
            _users = users;
        }

        public void Display()
        {
            Console.WriteLine("Username to remove");
            string userNameRemove = Console.ReadLine();
            Console.WriteLine("Users password to remove");
            string userpasswordRemove = Console.ReadLine();
            foreach (var item in _users)
            {


                Console.WriteLine("User  {0} successfully deleted. ", item.Value.Username);
                //AdminMenuView adminMain = new AdminMenuView(users);
                //adminMain.Display();

                //_users.Remove(userNameRemove);
                //var sl = new ShowListOfUsersView(_users);
                //sl.Display();
                Console.ReadLine();
                return;
            }
        }
    }
}
