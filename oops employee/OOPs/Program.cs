using System;

namespace OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseClass obj = new BaseClass();
            //obj.Print();

            //PartTimeEmployee obj1 = new PartTimeEmployee();
            //obj1.CalculateSalary(29);
            //obj1.NumberOfLeave();

            //PermanentEmployee obj = new PermanentEmployee();
            //obj.CalculateSalary(29);
            //obj.NumberOfLeave();

            PermanentEmployee obj3 = new PermanentEmployee();
            obj3.CalculateSalary(20);
            obj3.NumberOfLeave();

            PermanentEmployee obj4 = new PartTimeEmployee();
            obj4.CalculateSalary(20);
            obj4.NumberOfLeave();

            //Employee obj5 = new PermanentEmployee();
            //obj5.CalculateSalary(20);
            //obj5.NumberOfLeave();

            PartTimeEmployee obj6 = new PartTimeEmployee();
            obj6.CalculateSalary(20);
            obj6.NumberOfLeave();

            Console.ReadLine();
        }
    }
}


