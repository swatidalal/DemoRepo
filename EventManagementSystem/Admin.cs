using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EventManagementSystem
{
    public class Admin
    {

        public static string sqlConnectionStr = @"Data Source =SWATI; Initial Catalog=EventManagement;Integrated Security=True";

        public string AddEvent()
        {
            Console.WriteLine("Enter EventId Id:-");
            int EventId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter EventName  Name:-");
            string EventName = Console.ReadLine();

            Console.WriteLine("Enter the Cost of Event:");
            int EventCost = Convert.ToInt32(Console.ReadLine());


            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into Event values(" + EventId + ",'" + EventName + "'," + EventCost + ")", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Added";
            return "Added";


        }




    }
}
