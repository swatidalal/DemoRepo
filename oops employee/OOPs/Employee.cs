using System;

namespace OOPs
{
    class Employee
    {
        public int minimumWage = 5000;

        public virtual void NumberOfLeave()
        {
            Console.WriteLine("You are allowed to take 2 leaves per month");

        }
    }
}
