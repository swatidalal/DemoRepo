using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHandsOn
{
    public class Program
    {
        public static void Main(String[] args)
        {

            ListOfFlavors obj1 = new ListOfFlavors();
            Console.WriteLine("IceCream Flavors list :-");
            obj1.Data();
            Console.WriteLine();
            Array obj2 = new Array();
            obj2.ArrayPrint();
        }

    }
}
