using System;

namespace CheckAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Javid = new Account("cavid@code.edu.az", "12345");
            Javid.CheckAccount();
        }
    }
}
