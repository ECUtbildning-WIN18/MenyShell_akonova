using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Domain
{
    class ReceptionistMeny
    {
        private IDictionary<string, Users> users { get; }
        private IDictionary<string, Users> _users { get; }

        //var users = new Dictionary<string, User>();
        public ReceptionistMeny(IDictionary<string, Users> users)
        {
            _users = users;
        }


        public void ReceptView()
        {
            Console.WriteLine("1. List of users");
            
            Console.WriteLine("2. Exit");
         
            var recChoice = Console.ReadKey().Key;
            Dictionary<string, Users> users = new Dictionary<string, Users>();
            switch (recChoice)
            {
                case ConsoleKey.D1:
                    
                        foreach (KeyValuePair<string, Users> userDictionaryKeyValuePair in Program.userDictionary)
                        {

                            Users userdict = userDictionaryKeyValuePair.Value;

                            Console.WriteLine("UserName: {0},  User password:  {1},  User status:{2}", userdict.Username, userdict.Password, userdict.Status);
                        }

                    Console.WriteLine("2. Go to previouse meny.");
                     string choice = Console.ReadLine();
                    if (choice == "2")
                        ReceptView();
                   
                    Console.ReadLine();

                        break;

                    
                case ConsoleKey.D2:
                                            
                       Environment.Exit(0);
                        break;
                    

              }
        }
    }
}
