using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DisConnectedApproach
{
    public  class AccountData
    {

        public static string sqlConnectionStr = @"Data Source =SWATI; Initial Catalog=BankDb;Integrated Security=True";
        SqlConnection connection = new SqlConnection(sqlConnectionStr);

        public string InsertAccount()
        {
            Console.WriteLine("Enter Account No:");
            int AccNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Account Holder Name");
            string AccHolderName = Console.ReadLine();

            Console.WriteLine("Enter the Account Type:");
            string AccType = Console.ReadLine();


            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            string sql = "insert into Account values(" + AccNo + ",'" + AccHolderName + "','" + AccType + "')" ;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);


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
            string sql = "update Employee set  AccHolderName = '" + AccHolderName + "', AccType '" + AccType + "' where  AccNo = " + AccNo + "  " ;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);


            return "Updated";
        }





        public string DeleteAccount(int AccNo)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            string sql = "delete from Account where AccNo =" + AccNo;
            SqlDataAdapter adp = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);

            return "Customer Deleted with AccNo " + AccNo.ToString();

            Console.Read();

        }
        public DataTable SelectAccount()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            string db = sqlConnection.Database;
            string sql = "select * from Account";
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

        public DataTable SelectAccountByNo(int AccNo)
        {

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            string sql = "SELECT * from Account where AccNo = " + AccNo + " ";
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
