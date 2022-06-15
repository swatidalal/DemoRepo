using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DisConnectedApproach
{
    public class CustomerData
    {
        public static string sqlConnectionStr = @"Data Source=SWATI;Initial Catalog=BankDb;Integrated Security=True";
        SqlConnection connection = new SqlConnection(sqlConnectionStr);
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
            string sql="insert into Customer values(" + id + ",'" + name + "','" + email + "'," + mobile + ",'" + address + "')" ;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            
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
            string sql= "update Customer set CustName ='" + name + "' , Email='" + email + "' , Mobile=" + mobile + " , CustAddress='" + address + "' where CustId=" + id + "";

            SqlDataAdapter adp = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return "Update Customer with Id " + id.ToString();
        }

        public string DeleteCustomer(int CustId)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            string sql ="delete from Customer where custid=" + CustId;
            SqlDataAdapter adp = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            
            return "Customer Deleted with Customer_id " + CustId.ToString();

        }

        public DataTable SelectCustomers()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            string db = sqlConnection.Database;
            string sql = "select * from Customer";
            SqlDataAdapter adp = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    Console.Write(dataTable.Rows[i][j] + "\t\t");
                }
                Console.WriteLine();
            }
            return dataTable;


        }

        public DataTable SelectCustomersById(int id)
        {

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            string sql = "SELECT * from Customer where CustId = "+id+" " ;
            SqlDataAdapter adp = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    Console.Write(dataTable.Rows[i][j] + " ");
                }
                Console.WriteLine();
            }

            return dataTable;


        }
    }


}

