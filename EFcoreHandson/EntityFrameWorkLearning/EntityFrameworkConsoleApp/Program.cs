using EntityFrameWork.Data;
using EntityFrameWork.Data.Entities;

public class program
    {
        public static void Main()
        {
            CrudManager obj = new CrudManager();
            CrudManager obj1= new CrudManager();

        #region Employee
        //Console.WriteLine("Adding a new Employee");
        //obj.Insert(new Employee { Name = "Swati", Address = "Bahadurgarh" });
        //obj.Insert(new Employee { Name = "Naveen", Address = "Delhi" });
        //PrintAllEmployees();

        //Console.WriteLine("Updating Employee with EmployeeId 2");
        //obj.Update(3, new Employee { Name = "Jyoti", Address = "Pune" });
        //PrintAllEmployees();


        //Console.WriteLine("Deleting Employee details for EmployeeId 4");
        //obj.Delete(4);
        //PrintAllEmployees();

        //Console.WriteLine("Retrieving Employee details for EmployeeId 2");
        //var employee = obj.GetEmplpoyeeById(2);
        //Console.WriteLine($"Employee Name of employee ID 2 is {employee.Name}");



        #endregion

        #region Education
        //obj1.Insert(new EmployeeEducation { CourseName = "Bca", UniversityName = "Mdu", PassingYear = 2021, MarksPercentage = 75 });
        //obj1.Insert(new EmployeeEducation { CourseName = "Mca", UniversityName = "Mdu", PassingYear = 2021, MarksPercentage = 80 });
        //PrintAllEmployeeEducations();


        //Console.WriteLine("Updating Employee Education with ID 4");
        //obj.Update(4, new EmployeeEducation { CourseName = "Btech", UniversityName = "Jnu", PassingYear = 2015, MarksPercentage = 69 });
        //PrintAllEmployeeEducations();


        Console.WriteLine("Retrieving Employee Education details for ID 2");
        var employeeEducation = obj.GetEmplpoyeeEducationById(2);
        Console.WriteLine($"Course of  ID 2 is {employeeEducation.CourseName}");

        //Console.WriteLine("Deleting Employee Education details for ID 3");
        //obj.DeleteEmpEdu(3);
        //PrintAllEmployeeEducations();





        #endregion
    }

    static void PrintAllEmployees()
    {
        Console.WriteLine("Printing all Employees");
        CrudManager obj = new CrudManager();
        foreach (Employee employee in obj.GetAllEmployees())
        {
            Console.WriteLine($"Employee Name is {employee.Name} and address is {employee.Address}");
        }
    }

    static void PrintAllEmployeeEducations()
    {
        Console.WriteLine("Printing All Employees Education");
        CrudManager obj1 = new CrudManager();
        foreach (EmployeeEducation employeeEducation in obj1.GetAllEmployeesEducation())
        {
            Console.WriteLine($"Cousre name is {employeeEducation.CourseName} and University name is {employeeEducation.UniversityName} " +
                $"and Passing year{ employeeEducation.PassingYear} and  marks percentage is {employeeEducation.MarksPercentage}  ");
        }

    }


}
