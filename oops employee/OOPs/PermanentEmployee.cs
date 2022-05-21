using System;

namespace OOPs
{
    class PermanentEmployee : Employee
    {
        public void CalculateSalary(int workingDays)
        {
            int salary = workingDays * 500 + minimumWage;
            Console.WriteLine("Salary of full time employee is: " + salary);
        }
    }
}