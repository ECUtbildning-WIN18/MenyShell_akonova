using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Domain
{
    class AddUsersView
    {
       Users users = null; 

        bool bollanswer = false;
        public void AddUser()
        {
            while (bollanswer != true)
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                Console.WriteLine("Status: ");
                string status = Console.ReadLine();

                if (status == "admin" || status == "recept")
                {
                    Program.userDictionary.Add(username, new Users(username, password, status)); 
                    foreach (KeyValuePair<string, Users> userDictionaryKeyValuePair in Program.userDictionary)
                    {

                        Users userdict = userDictionaryKeyValuePair.Value;

                        Console.WriteLine("UserName: {0},  User password:  {1},  User status:{2}   ",  userdict.Username, userdict.Password, userdict.Status);
                    }
                    bollanswer = true; break;
                }


                else
                {
                    Console.WriteLine("Try again.");
                    bollanswer = false;
                }
            }
        }
    }
}