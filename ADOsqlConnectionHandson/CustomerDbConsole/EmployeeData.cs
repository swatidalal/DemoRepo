using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using System.Threading.Tasks;

namespace CustomerDbConsole
{
    internal class EmployeeData

    {
        public static string sqlConnectionStr = @"Data Source=SWATI;Initial Catalog=BankDb;Integrated Security=True";
       
        public  string InsertEmployee()
        {
            Console.WriteLine("Enter the employee ID");
            int EmpId= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Employee Name");
            string EmpName= Console.ReadLine();

            Console.WriteLine("Enter the employee age");
            int EmpAge= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Employee Name");
            string EmpAddress = Console.ReadLine();

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into Employee values(" + EmpId + ",'" + EmpName + "'," + EmpAge + ",'" + EmpAddress + "')", sqlConnection);
            sqlConnection.Open();//connection state is open
            cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close

            return "INSERTED";
        }

    }
}
