﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffTopicsHandsOn
{
    public class NestedClasses
    {
        
            public class Outer_class
            {
                public void Method(int a)
                {
                    Console.WriteLine("Outer class method");
                    int num = 1;
                    for (int i = a; i > 0; i--)
                    {
                        num = num * i;
                    }
                    Console.WriteLine("Factorial of Number is :" + num);
                }

                public class Inner_class
                {
                    public void Method1()
                    {
                        Console.WriteLine("Inside Inner class Method");
                        Console.WriteLine("Enter a Single Digit Number :");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Outer_class obj = new Outer_class();
                        obj.Method(num);
                    }
                }
            }
        }
    }
