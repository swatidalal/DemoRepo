using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolebasedBankingSystem
{
    public abstract class Accounts
    {
        public abstract string AccountNo { get; set; }
        public abstract string Deposit(double money);
        public abstract string Withdraw(double money);
        public virtual void BankName()
        {
            Console.WriteLine(" Welcome to XYZ Bank");
        }
        //Implementing IAccountHolder Interface in Account Class
        public void Withdraw()
        {
            Console.WriteLine("withdraw function called");
        }
        public void CheckCurrentBalance()
        {
            Console.WriteLine("Check balance function called");
        }
        public void ResetAtmPin()
        {
            Console.WriteLine("Reset pin function called");
        }
        public void TransferMoney()
        {
            Console.WriteLine("Transfer money function called");

        }
    }
}