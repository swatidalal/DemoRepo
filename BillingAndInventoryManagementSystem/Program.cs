﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingAndInventoryManagementSystem
{
    internal class Program
    {


        static void Main(string[] args)
        {
            FileHandlingClass fileobj = new FileHandlingClass();
            Console.WriteLine("Enter the User Details :-");
            fileobj.User_Module();
            Console.WriteLine("\n");
            Console.WriteLine();

            Console.WriteLine("Enter the Category Details :-");
            fileobj.Category_Module();
            Console.WriteLine("\n");
            Console.WriteLine();
            Console.WriteLine("Enter the Product Details :-");
            fileobj.Product_Module();
            Console.WriteLine("\n");

            Console.WriteLine();
            Console.WriteLine("Enter the PURCHASE AND Sales Details :-");
            fileobj.Purchase_and_Sales_Module();
            Console.WriteLine("\nEnter any key to continue");



            Console.ReadKey();
        }

    }
}