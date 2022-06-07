using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace CustomerDbConsole
{
    public class AccountData
    {
        public static string sqlConnectionStr = @"Data Source =SWATI; Initial Catalog=BankDb;Integrated Security=True";

        public string InsertAccount()
        {
            Console.WriteLine("Enter Account No:");
            int AccNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Account Holder Name");
            string AccHolderName = Console.ReadLine();

            Console.WriteLine("Enter the Account Type:");
            string AccType = Console.ReadLine();


            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into Account values(" + AccNo + ",'" + AccHolderName + "','" + AccType + "')", sqlConnection);
            sqlConnection.Open();//connection state is open
            cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close


            //SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            //SqlCommand cmd = new SqlCommand("Insert into Account values( " + AccNo + ",'" + AccHolderName + "','" + AccType + "')");

            //sqlConnection.Open();
            //cmd.ExecuteNonQuery();
            //sqlConnection.Close();
            return "Inserted";
        }
    }
}






















































































































































































        