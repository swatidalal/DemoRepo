using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Connect server
using System.Data;

namespace CustomerDbConsole
{
    internal class CustomerData
    {
        public static string sqlConnectionStr = @"Data Source=SWATI;Initial Catalog=BankDb;Integrated Security=True";
        public string InsertCustomer()
        {

            Console.Write("Enter Customer Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Customer email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Customer Mobile: ");
            int mobile = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer address: ");
            string address = Console.ReadLine();  

            //insert customer data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into Customer values(" + id + ",'" + name + "','" + email + "'," + mobile + ",'" + address + "')", sqlConnection);
            sqlConnection.Open();//connection state is open
            cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close

            return "Inserted";
        }

        public string UpdateCustomer()
        {
            
            Console.Write("Enter Customer Id to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer name  to update: ");
            string name = Console.ReadLine();

            Console.Write("Enter Customer email  to update: ");
            string email = Console.ReadLine();

            Console.Write("Enter Customer Mobile  to update: ");
            int mobile = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer address  to update: ");
            string address = Console.ReadLine();

            //insert customer data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("update Customer set CustName ='" + name + "' , Email='" + email + "' , Mobile=" + mobile + " , CustAddress='" + address + "' where CustId=" + id + "", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Updated";
            return "Updated";

        }

        public string DeleteCustomer(int CustId)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("delete from Customer where custid=" + CustId, sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Deleted";
            return "Deleted";

        }

        public DataTable SelectCustomers()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from Customer", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            //DataTable, DataSet
            sqlConnection.Close(); //connection state is close
            return dataTable;

            
        }

        public DataTable SelectCustomersById()
        {

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("SELECT * from Customer", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close(); //connection state is close
            return dataTable;

        }
        }
}
