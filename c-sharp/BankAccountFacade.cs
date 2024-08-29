using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class BankAccountCreationFacade
    {
        public void CreateAccounts(string name, string type)
        {
            Console.WriteLine($"Accounts created for {name} with {type}");

            if(type == "savings")
            {
                IAccount acc = new SavingsAccount();
                acc.Transfer(50000);
                acc.Deposit(2000);
            }
        }
    }
}
