﻿using System;
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
            return "";
        }

        public string DeleteCustomer()
        {
            return "";
        }

        public string SelectCustomers()
        {
            return "";
        }

        public string SelectCustomersById()
        {
            return "";
        }
    }
}
