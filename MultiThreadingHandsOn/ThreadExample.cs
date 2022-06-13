using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingHandsOn
{
    internal class ThreadExample
    {
        public  void Method1()
        {
            Console.WriteLine("Inside Method1 ");
            Thread.Sleep(10000);
        }

        public  void Method2()
        {
            Console.WriteLine("Inside Method2 ");
            Thread.Sleep(5000);
        }

        public  void Method3()
        {
            Console.WriteLine("Inside Method3 ");
        }

        public  void Method4()
        {
            Console.WriteLine("Inside Method4 ");
        }

        public  void Method5()
        {
            Console.WriteLine("Inside Method5 ");
        }
    }
}
