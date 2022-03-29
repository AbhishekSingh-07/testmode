using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberManagement
{
     public class Users
    {
        
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Password { get; set; }
        

        public override string ToString()
        {
            string usersdata = "";
          
            usersdata += UserName.ToString() + "\n";
            usersdata += FullName.ToString() + "\n";
            usersdata += Email.ToString() + "\n";
            usersdata += ContactNumber.ToString() + "\n";
            usersdata += Password.ToString() + "\n";
           

            return usersdata;
        }
    }
}
