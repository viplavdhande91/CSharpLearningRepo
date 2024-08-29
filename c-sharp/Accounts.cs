using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public interface IAccount
    {
        public void Deposit(BigInteger amount);
        public void WithDraw(BigInteger amount);
        public void Transfer(BigInteger amount);
        public int GetAccountNumber();

    }

    public class SavingsAccount : IAccount
    {
        public void Deposit(BigInteger amount)
        {
            Console.WriteLine($"Amount Deposited: {amount}");
        }

        public int GetAccountNumber()
        {
            throw new NotImplementedException();
        }

        public void Transfer(BigInteger amount)
        {
            Console.WriteLine($"Amount Transffered: {amount}");
        }

        public void WithDraw(BigInteger amount)
        {
            Console.WriteLine($"Amount Withdrawn: {amount}");
        }
    }

    public class CreditAccount : IAccount
    {


        public void Deposit(BigInteger amount)
        {
            Console.WriteLine($"Amount Deposited: {amount}");
                }

        public int GetAccountNumber()
        {
            throw new NotImplementedException();
        }

        public void Transfer(BigInteger amount)
        {
            Console.WriteLine($"Amount Transffered: {amount}");
        }

        public void WithDraw(BigInteger amount)
        {
            Console.WriteLine($"Amount Withdrawn: {amount}");
        }
    }






}
