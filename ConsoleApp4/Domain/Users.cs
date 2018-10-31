using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Domain
{
   public  class   Users
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }

        public  Users(string username, string password, string status)
        {
            Username = username;
            Password = password;
            Status = status;
            
        }

       
    }
}
