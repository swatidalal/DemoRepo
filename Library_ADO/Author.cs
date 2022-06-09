using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace Library_ADO
{
    internal class Author
    {
        public static string sqlConnectionStr = @"Data Source= SWATI;Initial Catalog=Library;Integrated Security= True";

        public string InsertAuthor()
        {
            Console.Write("Enter Author Id:- ");
            int Author_ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Author name:- ");
            string Author_Name = Console.ReadLine();

            Console.Write("Enter the Auhtor's age:-");
            int Author_Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Author Phone:- ");
            int Author_Phone = Convert.ToInt32(Console.ReadLine());

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into Author values(" + Author_ID + ",'" + Author_Name + "'," + Author_Age + "," + Author_Phone+ ")", sqlConnection);
            sqlConnection.Open();//connection state is open
            cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close



            return "record Inserted";

        }
    }
}

