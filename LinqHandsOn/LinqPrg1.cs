using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandsOn
{
    internal class LinqPrg1
    {
        public void PositiveNo()
        {
            

            List<int> list = new List<int>() { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            
            var nQuery =
            from Num in list
            where Num > 0
            where Num < 15
            select Num;
            Console.Write("\nThe Positive numbers within the range of Given List are : \n");
            foreach (var Num in nQuery)
            {
                Console.Write("{0}  ", Num);
            }
            Console.WriteLine("\n");
        }
    }
}
