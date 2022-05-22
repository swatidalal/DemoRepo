using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileHandlingHandsOn2
{
    public class Program
    {
        public static void Main (String []args)
        {
            FileHandlingReading obj1=new FileHandlingReading();
            obj1.Success();
            Console.WriteLine();
            obj1.Failed();
            Console.WriteLine();
            obj1.Missed();
            Console.WriteLine();
            obj1.Dialed();
            Console.WriteLine();
            


        }
    }
}
