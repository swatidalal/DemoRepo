using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHandsOn
{
    internal class Array
    {
        
        public void ArrayPrint()
        {
            //First array of integers
            int[] a = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Printing Array Elements");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);

            }
            Console.WriteLine();    

            // Array of Names
            string[] names = { "Tim", "Martin", "Nikki", "Sara" };
            Console.WriteLine("Printing Names");
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine();

            //Array of True False

            bool[] TF = new bool[10] {true,false,true,false,true,false,true,false,true,false};
            Console.WriteLine("Printing True False");
            for(int i = 0 ; i < TF.Length; i++)
            {
                Console.WriteLine(TF[i]);

            }

        }



        
    }
}
