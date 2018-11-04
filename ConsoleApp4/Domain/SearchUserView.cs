using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp4.Domain
{
    class SearchUserView
    {
        private readonly IDictionary<string, User> _usersDictionary;


        public SearchUserView(IDictionary<string, User> users)
        {
            _usersDictionary = users;
        }


        public List<User> Display()
        {
                Console.WriteLine("Search by users name:");
                string s = Console.ReadLine();
                List<User> resultList = new List<User>();

                foreach (var item in _usersDictionary.Values)
                {
                    if (item.Username.StartsWith(s))
                    {
                        resultList.Add(item);
                        /*  Console.WriteLine("Name:  {0}, Status:  {1} ", item.Username, item.Status);
                          Console.ReadLine();

                          asd = true;
                          Console.WriteLine("(D)elete.(N)o");
                          var cho = Console.ReadKey().Key;

                          switch (cho)
                          {
                              case ConsoleKey.D:
                                  string del = Console.ReadLine();
                                  Console.WriteLine("Delete user {0} ? _ (Y)es or (N)o", del);
                                  var yesorno = Console.ReadKey().Key;

                                  if (yesorno == ConsoleKey.Y)
                                  {
                                      RemoveUserView.RemoveUser();
                                      Console.WriteLine("User  {0} successfully deleted. ", item.Username);
                                      AdminMeny adminMain = new AdminMeny();
                                      adminMain.AdminDisplay();
                                  }

                                  else
                                  {
                                      Console.WriteLine("Name:  {0}, Status:  {1} ", item.Username, item.Status);
                                      Console.ReadLine();
                                  }

                                  break;
                              case ConsoleKey.N:
                                  AdminMeny adminMainView = new AdminMeny();
                                  adminMainView.AdminDisplay();
                                  break;
                          }
                          return resultList;
                      }
                      else
                      {
                          Console.WriteLine("No users found matching the search term {0}", s);
                          Thread.Sleep(2000);
                          asd = false;
                          AdminMeny admM = new AdminMeny();
                          admM.AdminDisplay();
                          return null;
                      }*/

                    }
                }

                if (resultList.Count == 0)
                {
                    Console.WriteLine("No users found matching the search term {0}", s);
                }
                return resultList;

        }

    }
}
