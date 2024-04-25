using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void MyBankDelegate();
    public class Bank
    {
        //            delegate       event name
        public event MyBankDelegate LowBalance;
        private double balance;
        public Bank()
        {
            balance = 5000;
        }
        public void Withdraw(double amount)
        {
            if(amount>balance)
            {
                LowBalance(); //raise or call an event
            }
            else
            {
                balance = balance-amount;
            }
        }
        public override string ToString()
        {
            return $"Your balance is {balance}";
        }
    }
    public class MyMessage
    {
        public void BalanceMsg()
        {
            Console.WriteLine("You have low balance");
        }
    }
}
