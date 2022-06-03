﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffTopicsHandsOn
{
    internal class RefAndOut
    {
        public void RefFunction()
        {
            Console.WriteLine("Enter the number Whose Factorial is required through ref:");
            int a = Convert.ToInt32(Console.ReadLine());
            int i = Rfactorial(ref a);
            Console.WriteLine("The factorial is : " + i);
            Console.ReadLine();
        }
        public int Rfactorial(ref int a)
        {
            int fact = 1;
            for (int i = a; i > 0; i--)
            {
                fact = fact * i;
            }
            a = fact;
            return a;
        }
        public void OutFunction()
        {
            Ofactorial(out int a);
            Console.WriteLine("The factorial is : " + a);
        }

        public int Ofactorial(out int a)
        {
            Console.WriteLine("Enter The No. Whose Factorial is required through out :");
            a = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = a; i > 0; i--)
            {
                fact = fact * i;
            }
            a = fact;
            return a;
        }

    }
}
