﻿using EntityFramework.Data.Entities;
using EntityFrameWork.Data;
using EntityFrameWork.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data
{
    public class CrudEducationDetails
    {
        DemoDbContext demoDbContext = new DemoDbContext();

        public void InsertEducation(List<EmployeeEducation> educationList)
        {
            demoDbContext.EmployeeEducations.AddRange(educationList);
            demoDbContext.SaveChanges();
        }

        public void InsertEmployeeAndEducation(Employee employee, List<EmployeeEducation> educationList)
        {
            var objEmployee = new Employee
            {
                Name = employee.Name,
                Address = employee.Address,
                EducationList = educationList

            };

            demoDbContext.Employees.AddRange(objEmployee);
            demoDbContext.SaveChanges();
        }

        public void InsertEducationofExistingEmployee(int employeeID, List<EmployeeEducation> educationList)
        {
            var objEmployee = demoDbContext.Employees.Where(x => x.ID == employeeID).Include(e => e.EducationList).First();

            objEmployee.Name = "Updated fourth time";

            // Do not write these 2 lines if you do not want to delete old records.
            objEmployee.EducationList.Clear();
            demoDbContext.SaveChanges();

            foreach (EmployeeEducation education in educationList)
            {
                objEmployee.EducationList.Add(education);
            }

            demoDbContext.Employees.Update(objEmployee);
            demoDbContext.SaveChanges();
        }

        public void PrintEmployeeAndEducation(int employeeID)
        {
            //var objEmployee = demoDbContext.Employees.Where(x => x.ID == employeeID).First();

            var objEmployee = demoDbContext.Employees.Where(x => x.ID == employeeID).Include(e => e.EducationList).First();

            Console.WriteLine($"Name of Employee is {objEmployee.Name}");

            foreach (EmployeeEducation education in objEmployee.EducationList)
            {
                Console.WriteLine($"Name of Course is {education.CourseName}");
            }

        }
    }
}