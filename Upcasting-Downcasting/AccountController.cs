using Service.Services.Implementations;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting
{
    public class AccountController
    {
        public void Login()
        {
            Console.Write("Enter an email: ");
            string email = Console.ReadLine();

            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            int role = 2;

            IAccountService account = new AccountService();
            Console.WriteLine(account.Login(email, password, role));
        }
    }
}
