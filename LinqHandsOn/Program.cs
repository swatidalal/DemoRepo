using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandsOn
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Link Hands On:-");


            //program 1
            LinqPrg1 prg1 = new LinqPrg1();
            prg1.PositiveNo();
            //Console.WriteLine();
            Console.WriteLine("Program 1 Completed-------------------------------------------------------------------------");

            //program 2
            LinqPrg2 prg2 = new LinqPrg2();
            prg2.FrequencyCount();
            Console.WriteLine("Program 2 Completed--------------------------------------------------------------------------");

            //program3 

            LinqPrg3 prg3 = new LinqPrg3();
            prg3.CharCount();
            Console.WriteLine("Program 3 Completed--------------------------------------------------------------------------");

            //program 4

            LinqPrg4 prg4 = new LinqPrg4();
            Console.WriteLine("please enter the Starting Character");
            string start = Console.ReadLine();
            Console.WriteLine("please enter the Ending Character ");
            string end = Console.ReadLine();
            prg4.SpecificChar();
            Console.WriteLine("Program 4 Completed--------------------------------------------------------------------------");

            // Program 5

            LinqPrg5 prg5 = new LinqPrg5();
            prg5.TopnRecords();
            Console.WriteLine("Program 5 Completed--------------------------------------------------------------------------");


            //program6

            LinqPrg6 prg6 = new LinqPrg6();
            prg6.StuGrades();
            Console.WriteLine("Program 6 Completed--------------------------------------------------------------------------");

            //program 7 and 8


            LinqPrg7 prg7 = new LinqPrg7();
            prg7.LastNameWithD();
            Console.WriteLine("Program 7 8 complted---------------------------------------------------------------------------");

            //Program 9

            LinQPrg9 prg9 = new LinQPrg9();
            prg9.DescFirstName();
            Console.WriteLine("Program 9 Completed--------------------------------------------------------------------------------");

            //Program 10

            LinqPrg10 prg10 = new LinqPrg10();
            prg10.CollectionWithL();
            Console.WriteLine("Program 10 completed-------------------------------------------------------------------------");

            //Program 11

            LinqPrg11 prg11 = new LinqPrg11();
            prg11.MultipleOf4_6();
            Console.WriteLine("Program 11 Completed----------------------------------------------------------------------------");
            
            Console.ReadLine();
        }
    }
}
