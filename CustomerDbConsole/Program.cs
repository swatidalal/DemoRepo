using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CustomerDbConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            Console.WriteLine("Please Select one of the Options :\n");
            Console.WriteLine("\t\tPress 1 For Customer Data");
            Console.WriteLine("\t\tPress 2 For Employee Data");
            Console.WriteLine("\t\tPress 3 For Account Data");
            // Console.WriteLine("\t\tPress 4 To Show All Information in the table");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            switch (choice1)
            {
                case 1:
                    CustomerData customerData = new CustomerData();
                    Console.WriteLine("Please Select one of the Options :\n");
                    Console.WriteLine("\t\tPress 1 to Insert Data.");
                    Console.WriteLine("\t\tPress 2 to Update Data.");
                    Console.WriteLine("\t\tPress 3 to Delete Data.");
                    Console.WriteLine("\t\tPress 4 to Show All Customer Table Data.");
                    Console.WriteLine("\t\tPress 5 to Show a Perticular Customer Data.");

                    int choice2 = Convert.ToInt32(Console.ReadLine());
                    switch (choice2)
                    {
                        case 1:
                            string result = customerData.InsertCustomer();
                            Console.WriteLine(result);
                            break;
                        case 2:
                            result = customerData.UpdateCustomer();
                            Console.WriteLine(result);
                            break;
                        case 3:
                            Console.WriteLine("\nEnter The Customer ID to Delete :");
                            int CustID = Convert.ToInt32(Console.ReadLine());
                            result = customerData.DeleteCustomer(CustID);
                            Console.WriteLine(result);
                            break;
                        case 4:
                            Console.WriteLine();
                            dt = customerData.SelectCustomers();
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
                            Console.WriteLine("Enter The Customer ID To See Its Details : ");
                            int CustId = Convert.ToInt32(Console.ReadLine());
                            dt = customerData.SelectCustomersById(CustId);
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                // int ID = (int)dt.Rows[i][0];
                                if ((int)dt.Rows[i][0] == CustId)
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
                            Console.ReadLine ();
                            break;

                    }

                    break;
                case 2:
                    EmployeeData employeeData = new EmployeeData();
                    Console.WriteLine("Please Select one of the Options :\n");
                    Console.WriteLine("\t\tPress a to Insert Data.");
                    Console.WriteLine("\t\tPress b to Update Data.");
                    Console.WriteLine("\t\tPress c to Delete Data.");
                    Console.WriteLine("\t\tPress d to Show All Employee Table Data.");
                    Console.WriteLine("\t\tPress e to Show a Perticular Employee Data.");

                    string choice3 = Console.ReadLine();
                    switch (choice3)
                    {
                        case "a":
                            string result = employeeData.InsertEmployee();
                            Console.WriteLine(result);
                            break;
                        case "b":
                            result = employeeData.UpdateEmployee();
                            Console.WriteLine(result);
                            break;
                        case "c":
                            Console.WriteLine("\nEnter The Customer ID to Delete :");
                            int EmpID = Convert.ToInt32(Console.ReadLine());
                            result = employeeData.DeleteEmployee(EmpID);
                            Console.WriteLine(result);
                            break;
                        case "d":
                            Console.WriteLine();
                            dt = employeeData.SelectEmployee();
                            if (dt.Rows.Count == 0)
                            {
                                Console.WriteLine("NO DATA FOUND");
                            }
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
                        case "e":
                            Console.WriteLine("Enter The Employee ID To See Its Details : ");
                            int SearchID = Convert.ToInt32(Console.ReadLine());
                            dt = employeeData.SelectEmployeeById();
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                // int ID = (int)dt.Rows[i][0];
                                if ((int)dt.Rows[i][0] == SearchID)
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
                            break;

                    }
                    break;
                case 3:
                    AccountData accountData = new AccountData();
                    Console.WriteLine("Please Select one of the Options :\n");
                    Console.WriteLine("\t\tPress a to Insert Data.");
                    Console.WriteLine("\t\tPress b to Update Data.");
                    Console.WriteLine("\t\tPress c to Delete Data.");
                    Console.WriteLine("\t\tPress d to Show All Account Table Data.");
                    Console.WriteLine("\t\tPress e to Show a Perticular Account Data.");

                    string choice4 = Console.ReadLine();
                    switch (choice4)
                    {
                        case "a":
                            string result = accountData.InsertAccount();
                            Console.WriteLine(result);
                            break;
                        case "b":
                            result = accountData.UpdateAccount();
                            Console.WriteLine(result);
                            break;
                        case "c":
                            Console.WriteLine("\nEnter The Account Number to Delete Its Details :");
                            int EmpID = Convert.ToInt32(Console.ReadLine());
                            result = accountData.DeleteAccount(EmpID);
                            Console.WriteLine(result);
                            break;
                        case "d":
                            Console.WriteLine();
                            dt = accountData.SelectAccount();
                            if (dt.Rows.Count == 0)
                            {
                                Console.WriteLine("NO DATA FOUND");
                            }
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
                        case "e":
                            Console.WriteLine("Enter The Account Number To See Its Details : ");
                            int SearchID = Convert.ToInt32(Console.ReadLine());
                            dt = accountData.SelectAccountByNo();
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                // int ID = (int)dt.Rows[i][0];
                                if ((int)dt.Rows[i][0] == SearchID)
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
                            break;

                    }
                    break;
                case 4:
                    break;
            }

        }
    }

        }



        

