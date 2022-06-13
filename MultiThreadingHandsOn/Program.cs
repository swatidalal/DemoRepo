using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New Thread Started");
            Thread t1 = new Thread(HelloThread.Method);
            t1.Start();
            Console.WriteLine("Call Write('*') in main Thread...\n");

            // In the main thread print out character '*'
            for (int i = 0; i < 50; i++)
            {
                Console.Write("* ");
                // Sleep 70 millisenconds.
                Thread.Sleep(70);
            }
            Console.WriteLine("\n Main Thread finished!\n");




            ThreadExample obj = new ThreadExample();

            //obj.Method1();
            //obj.Method2();
            //obj.Method3();
            //obj.Method4();
            //obj.Method5();

            Thread thread = new Thread(new ThreadStart(obj.Method1));
            thread.Start();

            thread = new Thread(new ThreadStart(obj.Method2));
            thread.Start();

            thread = new Thread(new ThreadStart(obj.Method3));
            thread.Start();

            thread = new Thread(new ThreadStart(obj.Method4));
            thread.Start();

            thread = new Thread(new ThreadStart(obj.Method5));
            thread.Start();





            Console.ReadLine();

        }
    }
}
