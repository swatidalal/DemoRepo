using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffTopicsHandsOn
{
    public class Tupples

    {
        public void PerformTupleExample()
        {
            var student = new Tuple<string, string, string, int>("Swati", "Dalal", "Developer", 2022);
            Console.WriteLine("Print the tuple");
            Console.WriteLine("First Name=" + student.Item1);
            Console.WriteLine("Last Nmae= " + student.Item2);
            Console.WriteLine("Designation = " + student.Item3);
            Console.WriteLine("Year= " + student.Item4);

        }




    }
}
