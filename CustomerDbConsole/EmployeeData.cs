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

            Console.WriteLine("Enter the Employee Address");
            string EmpAddress = Console.ReadLine();

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into Employee values(" + EmpId + ",'" + EmpName + "'," + EmpAge + ",'" + EmpAddress + "')", sqlConnection);
            sqlConnection.Open();//connection state is open
            cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close

            return "INSERTED";
        }

        public string UpdateEmployee()
        {
            Console.WriteLine("Enter the employee ID");
            int EmpId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Employee Name");
            string EmpName = Console.ReadLine();

            Console.WriteLine("Enter the employee age");
            int EmpAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Employee Address");
            string EmpAddress = Console.ReadLine();

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("update Employee set  EmpName = '" + EmpName + "' , EmpAge = " + EmpAge + " , EmpAddress = '" + EmpAddress + "'  where EmpId = " +  EmpId + " ", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Updated";
            return "Updated";
            Console.Read();
        


        }
        public string DeleteEmployee(int EmpId)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("delete from Employee where EmpId=" + EmpId, sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Deleted";
            return "Deleted";
            Console.Read();

        }
        public DataTable SelectEmployee()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from Employee", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            //DataTable, DataSet
            sqlConnection.Close(); //connection state is close
            return dataTable;


        }

        public DataTable SelectEmployeeById()
        {

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("SELECT * from Employee", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close(); //connection state is close
            return dataTable;

        }




    }
}
