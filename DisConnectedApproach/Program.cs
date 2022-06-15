using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisConnectedApproach
{
    public class Program
    {
        static void Main(string[] args)
        {

           
            CustomerData customerData = new CustomerData();
            //customerData.InsertCustomer();
            //customerData.UpdateCustomer();
            //customerData.SelectCustomers();
            //customerData.DeleteCustomer(101);
            //customerData.SelectCustomersById(1020);
            
            AccountData accountData = new AccountData();
            //accountData.InsertAccount();
            //accountData.UpdateAccount();
            //accountData.DeleteAccount(1001);
            accountData.SelectAccountByNo(1002);
            //accountData.SelectAccount();


            Console.ReadLine();

        }
    }
}
