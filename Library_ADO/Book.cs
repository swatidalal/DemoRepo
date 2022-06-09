using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace Library_ADO
{
    internal class Book
    {
        public static string sqlConnectionStr = @"Data Source= SWATI;Initial Catalog=Library;Integrated Security= True";

        public string InsertBook()
        {
            Console.Write("Enter Book Id:- ");
            int Book_ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book name:- ");
            string Book_Name = Console.ReadLine();

            Console.Write("Enter the Book Author:-");
            string Book_Author = Console.ReadLine();

            Console.Write("Enter the Book Publication:-");
            string Book_Publication = Console.ReadLine();


            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into Book values(" + Book_ID + ",'" + Book_Name + "','" + Book_Author + "','" + Book_Publication + "')", sqlConnection);
            sqlConnection.Open();//connection state is open
            cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close



            return "record Inserted";


        }
    }
}
