using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using T2210A_Bank.Demo;


namespace T2210A_Bank
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

           
            account.BalanceChanged += (newBalance) =>
            {
                Console.WriteLine("So du thay doi: " + newBalance);
            };

            
            account.Deposit(1000);

            
            account.Withdraw(500);
        }
    }
}
