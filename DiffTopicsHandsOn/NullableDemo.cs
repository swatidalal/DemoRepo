﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffTopicsHandsOn
{
    internal class NullableDemo
    {
        public void PerformNullableExample()
        {
            string name = null;//String can be nulll but int , float , double, char Could not be null
                               //int number = null;//it Gives an error Because We can't Assign to a Value type Datataype'variable
            int? number = null;//ShortHand Triks To Assign null to a value type variable
            Nullable<int> number2 = null;
            Console.WriteLine("String name  null " + name);
            Console.WriteLine(" int Number  null " + number);
            Console.WriteLine(" int Number 2 null " + number2);
            number = 20;//now assign some value to the int variable
            Console.WriteLine("now assign some value to the int variable=" + number);
        }
    }
}
