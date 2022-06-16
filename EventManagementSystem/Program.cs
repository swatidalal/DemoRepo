using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EventManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataTable dt = new DataTable();
            Console.WriteLine("Please Choose Profile to Continue :\n");
            Console.WriteLine("\t\tPress 1 For Super Admin");
            Console.WriteLine("\t\tPress 2 For Admin");
            Console.WriteLine("\t\tPress 3 For Customer");

            int choice1 = Convert.ToInt32(Console.ReadLine());
            switch (choice1)
            {
                case 1:
                    SuperAdmin superAdmin = new SuperAdmin();
                    Console.WriteLine("Please Select one of the Options :\n");
                    Console.WriteLine("\t\tPress 1 to Insert Admin.");
                    Console.WriteLine("\t\tPress 2 to Update Admin.");
                    Console.WriteLine("\t\tPress 3 to Delete Admin.");
                    Console.WriteLine("\t\tPress 4 to Show All Admin Table Data.");
                    Console.WriteLine("\t\tPress 5 to Show a Particular Admin Data.");

                    int choice2 = Convert.ToInt32(Console.ReadLine());
                    switch (choice2)
                    {
                        case 1:
                            string result = superAdmin.InsertAdmin();
                            Console.WriteLine(result);
                            break;
                        case 2:
                            result = superAdmin.UpdateAdmin();
                            Console.WriteLine(result);
                            break;
                        case 3:
                            Console.WriteLine("\nEnter The Admin ID to Delete :");
                            int AdminId = Convert.ToInt32(Console.ReadLine());
                            result = superAdmin.DeleteAdmin(AdminId);
                            Console.WriteLine(result);
                            break;
                        case 4:
                            Console.WriteLine();
                            dt = superAdmin.ShowAdmin();
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    Console.Write(dt.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter The AdminId To See Its Details : ");
                            int AdminId1 = Convert.ToInt32(Console.ReadLine());
                            dt = superAdmin.SelectAdminById(AdminId1);
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                // int ID = (int)dt.Rows[i][0];
                                if ((int)dt.Rows[i][0] == AdminId1)
                                {
                                    {
                                        for (int j = 0; j < dt.Columns.Count; j++)
                                        {

                                            Console.Write(dt.Rows[i][j] + "\t\t");
                                        }
                                    }
                                }
                                Console.WriteLine();
                            }
                            Console.ReadLine();
                            break;

                    }

                    break;


            }
        }
    }
}


