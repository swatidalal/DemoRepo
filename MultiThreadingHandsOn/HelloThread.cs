using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingHandsOn
{
    public class HelloThread
    {
        public static void Method()
        {
            Console.WriteLine("First thread");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(i);
                

                //// Sleep 100 millisenconds
                //Thread.Sleep(100);


            }

        }
        
    }
}
