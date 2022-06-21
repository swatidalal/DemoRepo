using EntityFrameWork.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Data
{
    public class CrudManager
    {
        DemoDbContext demoDbContext = new DemoDbContext();

        #region Employee
        public List<Employee> GetAllEmployees()
        {
            var employee = demoDbContext.Employees.ToList();
            return employee;
        }

        public Employee GetEmplpoyeeById(int employeeId)
        {
            // Tracking not required
            var employee = demoDbContext.Employees.Where(x => x.ID == employeeId)
                            .AsNoTracking()
                            .FirstOrDefaultAsync().Result;

            if (employee == null)
            {
                throw new Exception($"Employee with ID:{employeeId} Not Found");
            }

            return employee;
        }


        public void Insert(Employee employee)
        {
            demoDbContext.Employees.Add(employee);
            demoDbContext.SaveChanges();
        }

        public void Update(int employeeId, Employee modifiedEmployee)
        {
            var employee = demoDbContext.Employees.Where(x => x.ID == employeeId).FirstOrDefault();
            if (employee == null)
            {
                throw new Exception($"Employee with ID:{employeeId} Not Found");
            }

            employee.Name = modifiedEmployee.Name;
            employee.Address = modifiedEmployee.Address;

            // Entity state : Modified
            demoDbContext.Employees.Update(employee);

            // This issues insert statement
            demoDbContext.SaveChanges();
        }

        public void Delete(int employeeId)
        {
            var employee = demoDbContext.Employees.Where(x => x.ID == employeeId).FirstOrDefault();
            if (employee == null)
            {
                throw new Exception($"Employee with ID:{employeeId} Not Found");
            }

            // Entity state : Deleted
            demoDbContext.Employees.Remove(employee);

            // This issues insert statement
            demoDbContext.SaveChanges();

        }

        #endregion

        #region EmployeeEducation

        public List<EmployeeEducation> GetAllEmployeesEducation()
        {
            var employeeEducations = demoDbContext.EmployeeEducations.ToList();
            return employeeEducations;
        }
        public void Insert(EmployeeEducation employeeEducation)
        {
            demoDbContext.EmployeeEducations.Add(employeeEducation);
            demoDbContext.SaveChanges();
        }

        public EmployeeEducation GetEmplpoyeeEducationById(int employeeEducationId)
        {
            // Tracking not required
            var employeeEducation = demoDbContext.EmployeeEducations.Where(x => x.ID == employeeEducationId)
                            .AsNoTracking()
                            .FirstOrDefaultAsync().Result;

            if (employeeEducation == null)
            {
                throw new Exception($"Employee with ID:{employeeEducationId} Not Found");
            }

            return employeeEducation;
        }
        public void Update(int employeeEducationId, EmployeeEducation modifiedEmployeeEducation)
        {
            var employeeEducation = demoDbContext.EmployeeEducations.Where(x => x.ID == employeeEducationId).FirstOrDefault();
            if (employeeEducation == null)
            {
                throw new Exception($"Employee with ID:{employeeEducationId} Not Found");
            }

            employeeEducation.CourseName = modifiedEmployeeEducation.CourseName;
            employeeEducation.UniversityName = modifiedEmployeeEducation.UniversityName;
            employeeEducation.PassingYear = modifiedEmployeeEducation.PassingYear;
            employeeEducation.MarksPercentage = modifiedEmployeeEducation.MarksPercentage;

            // Entity state : Modified
            demoDbContext.EmployeeEducations.Update(employeeEducation);

            // This issues insert statement
            demoDbContext.SaveChanges();
        }
        public void DeleteEmpEdu(int employeeEducationId)
        {
            var employeeEducation = demoDbContext.EmployeeEducations.Where(x => x.ID == employeeEducationId).FirstOrDefault();
            if (employeeEducation == null)
            {
                throw new Exception($"Employee with ID:{employeeEducationId} Not Found");
            }

            // Entity state : Deleted
            demoDbContext.EmployeeEducations.Remove(employeeEducation);

            // This issues insert statement
            demoDbContext.SaveChanges();
        }


        #endregion


    }
}
