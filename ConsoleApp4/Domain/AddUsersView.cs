using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Domain
{

   class AddUsersView
    {
       
        private readonly IDictionary<string, User> _usersDictionary;


        public AddUsersView(IDictionary<string, User> users)
        {
            _usersDictionary = users;
        }

        public   void AddUser()
    {
        Console.WriteLine("  Username: ");
        string username = Console.ReadLine();

        Console.WriteLine(" \n Password: ");
        string password = Console.ReadLine();

        Console.WriteLine(" \n Status: ");
        string status = Console.ReadLine();

        if (status == "admin" || status == "recept")
        {
              

                _usersDictionary.Add(username, new User(username, username, status));
                foreach (KeyValuePair<string, User> userDictionaryKeyValuePair in Program.userDictionary)
                {

                    User userdict = userDictionaryKeyValuePair.Value;

                    Console.WriteLine("UserName: {0},  User password:  {1},  User status:{2}   ", userdict.Username, userdict.Password, userdict.Status);
               }


            }


        else
        {
            Console.WriteLine("Try again.");

        }

    }
    }
    }
