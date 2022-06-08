using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandsOn
{
    internal class LinqPrg11
    {
        public void MultipleOf4_6()
        {
            List<int> mixedNumbers = new List<int>()
            {15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96};

            var res = (from item in mixedNumbers
                       where item % 4 == 0 && item % 6 == 0
                       select item).ToList();

            Console.WriteLine("The following numbers are multiples of 4 or 6:");
            foreach (var resultitem in res)
            {
                Console.Write($"{resultitem}, ");
            }
            Console.WriteLine();


        }
    }
}
