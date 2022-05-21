using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolebasedBankingSystem
{
    public class CurrentAccount : Accounts
    {
        private string accNo;
        public override string Deposit(double money)
        {
            return "AC type current : Deposit transaction done sucessfully";

        }
        public override string Withdraw(double money)
        {
            return "AC type current : Withdraw transaction done sucessfully";
        }

        public override string AccountNo
        {
            get
            {
                return accNo;
            }
            set
            {
                accNo = value;
            }
        }
    }
}