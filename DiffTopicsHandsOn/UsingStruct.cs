﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffTopicsHandsOn
{
    struct Employee
    {
        public string Name;
        public string lastname;
        public string Designation;
        public int Year;


    }
    public class UsingStruct
    {
        public void PerFormStruct()
        {
            Employee emp = new Employee();
            emp.Name = "Swati";
            emp.lastname = "Dalal";
            emp.Designation = "Developer";
            emp.Year = 2022;
            Console.WriteLine("Print the Struct");
            Console.WriteLine("First Name=" + emp.Name);
            Console.WriteLine("Last Nmae= " + emp.lastname);
            Console.WriteLine("Designation = " + emp.Designation);
            Console.WriteLine("Year= " + emp.Year);
        }
        public void StructCanNotBeNullAssign()
        {
            Employee emp1 = new Employee();
            //emp1 = null;//it gives an error
            Console.WriteLine("Here null gives an error is (Cannot convert null to 'type' because it is a non-nullable value type)");

        }



    }
}
