using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingHandson
{
    public class Program

    {
        static void Main(string[] args)
        {
            FileHandlingDemo obj1 = new FileHandlingDemo();
            obj1.Readfile();
            Console.WriteLine();
            Console.WriteLine("read operation completed");
        }

    }
}