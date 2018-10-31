using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Domain
{
    public class RemoveUserView
    {
        

        public void RemoveUser()
        {
            Console.WriteLine("Username to remove");
            string userNameRemove = Console.ReadLine();
            Console.WriteLine("Users password to remove");
            string userpasswordRemove = Console.ReadLine();

            Program.userDictionary.Remove(userNameRemove); 

           
        }
    }
}
