using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandsOn
{
    internal class LinqPrg3
    {
        public void CharCount()
        {
            string str;

            
            Console.WriteLine("Input the string : ");
            str = "apple"; 
            Console.WriteLine(str);

            var FreQ = from x in str
                       group x by x into y
                       select y;

            Console.Write("The frequency of the characters are :\n");
            foreach (var vcc in FreQ)
            {
                Console.WriteLine("Character " + vcc.Key + ": " + vcc.Count() + " times");
            }
        }
    }
}
