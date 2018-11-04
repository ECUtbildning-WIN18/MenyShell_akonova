using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Domain
{
    public class ShowListOfUsersView
    {
        private  IDictionary<string, User> _usersDictionary;

        public ShowListOfUsersView(IDictionary<string, User> users)
        {
            _usersDictionary = users;
        }

        public void Display()
        {
            foreach (User u in _usersDictionary.Values)
            {
                Console.WriteLine("UserName: {0},  User password:  {1},  User status:{2}   ", 
                    u.Username, u.Password, u.Status);
            }
        }

    }
}





