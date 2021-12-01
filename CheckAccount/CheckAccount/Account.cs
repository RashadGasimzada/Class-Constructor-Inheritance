using System;
using System.Collections.Generic;
using System.Text;

namespace CheckAccount
{
    class Account
    {
        string email;
        string password;

        public Account(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public void CheckAccount()
        {
            if (this.email == "cavid@code.edu.az" && this.password == "12345")
            {

                Console.WriteLine("Girish olundu");
            }
            else
            {
                Console.WriteLine("Mail ve yaxud password sehvdir");
            }
        }
    }
}
