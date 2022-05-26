using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllBasedHandsOn;

namespace EBillDllHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EBill eBill = new EBill();
            eBill.AddDetails();

            Console.WriteLine("EBill System");
            Console.WriteLine("");
            Console.WriteLine("details Of Customer:-");
            eBill.ShowCustomerDetails(1005);
            Console.WriteLine("");
            Console.WriteLine("Bill Details Of Customer");
            eBill.ShowEBill(1005);
            Console.WriteLine("");
            Console.WriteLine("Report OF Customer");
            eBill.ShowEBillReport();
            Console.WriteLine("");
            Console.WriteLine("Ebill Dll HandsOn Completed");


        }
    }

}