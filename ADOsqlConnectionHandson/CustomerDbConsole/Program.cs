using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDbConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    CustomerData customerData = new CustomerData();
        //    string result = customerData.InsertCustomer();
        //    Console.WriteLine(result);
            
            //EmployeeData employeeData = new EmployeeData();
            //string result1 = employeeData.InsertEmployee();
            //Console.WriteLine(result1);

            AccountData accountData = new AccountData();
             string result2=accountData.InsertAccount();
            Console.WriteLine(result2); 


            Console.ReadLine();
        }
    }
}
