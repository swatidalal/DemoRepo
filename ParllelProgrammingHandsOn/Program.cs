using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParllelProgrammingHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParllelProgramming parallelExecutions = new ParllelProgramming();


            //taskParallelExecutions.Displayfood();

            //creating threads

            Thread t1 = new Thread(parallelExecutions.ShowBuyerReport);
            Thread t2 = new Thread(parallelExecutions.ShowDealerReport);

            //stating threads
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}
