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


            
            return "Inserted";
        }

        public string UpdateAccount()
        {
            Console.WriteLine("Enter Account No:");
            int AccNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Account Holder Name");
            string AccHolderName = Console.ReadLine();

            Console.WriteLine("Enter the Account Type:");
            string AccType = Console.ReadLine();


            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("update Employee set  AccHolderName = '" + AccHolderName + "', AccType '" + AccType + "' where  AccNo = " +AccNo +"  ", sqlConnection);
            sqlConnection.Open();//connection state is open
            cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close



            return "Updated";
        }








        public string DeleteAccount(int AccNo)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("delete from Employee where AccNo=" + AccNo, sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Deleted";
            return "Deleted";
            Console.Read();

        }
        public DataTable SelectAccount()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from Account", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            //DataTable, DataSet
            sqlConnection.Close(); //connection state is close
            return dataTable;


        }

        public DataTable SelectAccountByNo()
        {

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("SELECT * from Account", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close(); //connection state is close
            return dataTable;

        }
    }
}






















































































































































































        