using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffTopicsHandsOn
{
    internal class Checked_Unchecked
    {
        //public void CheckedKeyword()
        //{
            
        //    checked
        //    {
        //        int val = int.MaxValue;
        //        Console.WriteLine(val + 2);
        //    }
        // }

        //unchecked keyword
        public void UncheckedKeyword()
        {
            unchecked
            {

                {
                    int val = int.MaxValue;
                    Console.WriteLine(val + 2);
                }
            }
        }
            
    }
}
