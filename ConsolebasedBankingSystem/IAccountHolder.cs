using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolebasedBankingSystem
{
    internal interface IAccountHolder
    {
        void Withdraw();
        void CheckCurrentBalance();
        void ResetAtmPin();
        void TransferMoney();
    }
}