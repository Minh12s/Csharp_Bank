using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_Bank.Demo
{
    public class BankAccount
    {
        private decimal balance;

        
        public event Action<decimal> BalanceChanged;

       
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (balance != value)
                {
                    balance = value;
                    OnBalanceChanged(balance);
                }
            }
        }

        
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        
        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("so du khong du.");
            }
        }

        
        protected virtual void OnBalanceChanged(decimal newBalance)
        {
            BalanceChanged?.Invoke(newBalance);
        }
    }
}

