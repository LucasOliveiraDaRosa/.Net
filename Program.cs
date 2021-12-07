using System;
using AppHeranca.Entities;

namespace AppHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(18906, "Lucas", 500.00);
            Account acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.00);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            
        }
    }
}
