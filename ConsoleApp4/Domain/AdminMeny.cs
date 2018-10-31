using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Domain
{
    class AdminMeny
    {
        public void AdminDisplay() 
        {
            Console.WriteLine("1. List of User");
            Console.WriteLine("2. Add user");
            Console.WriteLine("3. Remove user");
            Console.WriteLine("4.Exit");

            var adminChoice = Console.ReadLine();
            
            switch (adminChoice)
            {
                case "1":
                    

                    foreach (KeyValuePair<string, Users> userDictionaryKeyValuePair in Program.userDictionary)
                    {

                        //Console.WriteLine("Username: {0}, password: {1}", userDictionaryKeyValuePair.Key, userDictionaryKeyValuePair.Value.Password );
                        Users userdict = userDictionaryKeyValuePair.Value;

                        Console.WriteLine("UserName: {0},  User password:  {1},  User status:{2}   ", userdict.Username, userdict.Password, userdict.Status);
                    }

                    Console.ReadLine();
                    break;

                case "2":

                    var addUserView = new AddUsersView();
                    addUserView.AddUser();
                    Console.ReadLine();
                    break;

                case "3":

                    var removeUser = new RemoveUserView();
                    removeUser.RemoveUser();
                    Console.ReadLine();
                    break;

                case "4":
                    Environment.Exit(0);
                    break;


            }
        }
    }
}
