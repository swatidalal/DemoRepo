using System;

namespace OOPs
{
    class PartTimeEmployee : Employee
    {
        public void CalculateSalary(int workingDays)
        {
            int salary = workingDays * 300 + minimumWage;
            Console.WriteLine("Salary of part time employee is: " + salary);
        }

        public override void NumberOfLeave()
        {
            Console.WriteLine("You are allowed to take 1 leaves per month");
        }
    }
}