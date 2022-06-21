
using EFcoreOrderAssignmentDll;
using EFcoreOrderAssignmentDll.Entities;

public class program
{
    static void Main(string[] args)
    {
        CRUDManagers cRUDManagers = new CRUDManagers();


        Console.WriteLine("********************************************Welcome to Order Assignment******************************************");
        Console.WriteLine("Please Select One of the Options:\n");
        Console.WriteLine("\t\tPress 1 for Item Master");
        Console.WriteLine("\t\tPress 2 for Customer Master");
        Console.WriteLine("\t\tPress 3 to Exit");
        int choice1 = Convert.ToInt32(Console.ReadLine());
        switch (choice1)
        {


            case 1:

            Portal:



                Console.WriteLine("****************************************Welcome to Item Portal************************************");
                Console.WriteLine("Please Select one of the Options :\n");
                Console.WriteLine("\t\tPress 1 to Insert Item Data.");
                Console.WriteLine("\t\tPress 2 to Delete Item Data.");
                Console.WriteLine("\t\tPress 3 to Update Item.");
                Console.WriteLine("\t\tPress 4 to all item Table data.");
                Console.WriteLine("\t\tPress 5 to Exit");

                int choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2)
                {
                    case 1:
                        cRUDManagers.AddItem();
                        PrintAllItems();
                        goto Portal;
                    case 2:
                        cRUDManagers.DeleteItem();
                        goto Portal;
                    case 3:
                        PrintAllItems();
                         cRUDManagers.UpdateItem();
                        PrintAllItems();
                        goto Portal;
                    case 4:
                        cRUDManagers.GetAllItems();
                        PrintAllItems();
                        goto Portal;
                    case 5:
                      
                        break;


                    default:
                        Console.WriteLine("Wrong Choise Try Again");
                        goto Portal;


                        break;

                }
                break;

            case 2:



            portal1:

                Console.WriteLine("********************************************Welcome to Customer Portal*****************************************");
                Console.WriteLine("Please Select one of the Options :\n");
                Console.WriteLine("\t\tPress 1 to Insert New Customer.");
                Console.WriteLine("\t\tPress 2 to Update Customer.");
                Console.WriteLine("\t\tPress 3 to Delete Customer.");
                Console.WriteLine("\t\tPress 4 to all Customer Table data.");
                Console.WriteLine("\t\tPress 5 to Exit");
                int choice3 = Convert.ToInt32(Console.ReadLine());
                switch (choice3)
                {
                    case 1:
                         cRUDManagers.AddCustomer();
                        PrintAllCustomers();
                        goto portal1;

                        break;

                    case 2:
                        cRUDManagers.UpdateCustomer();
                        PrintAllCustomers();
                        goto Portal;


                        break;

                    case 3:
                         cRUDManagers.DeleteCustomer();
                        PrintAllCustomers();
                        goto portal1;

                        break;


                    case 4:
                        cRUDManagers.GetAllcustomers();
                        PrintAllCustomers();
                        goto portal1;
                        break;


                    case 5:
                        break;
                }


                Console.ReadLine();


                break;

            case 3:

                break;





        }
    }

    
    static void PrintAllItems()
    {
        Console.WriteLine("Printing all Items");
        CRUDManagers obj = new CRUDManagers();
        foreach (ItemMaster itemMaster in obj.GetAllItems())
        {
            Console.WriteLine($"Item Name is {itemMaster.Item_Name} and Rate is {itemMaster.Item_Rate} and Quantity is {itemMaster.Item_Qty}");
        }
    }

    static void PrintAllCustomers()
    {
        Console.WriteLine("Printing all Customers");
        CRUDManagers obj = new CRUDManagers();
        foreach (CustomerMaster customerMaster in obj.GetAllcustomers())
        {
            Console.WriteLine($"Customer email is {customerMaster.Customer_Email} and first name is {customerMaster.Customer_FName} and last name is {customerMaster.Customer_LName} and Phone no is {customerMaster.Customer_Phone}");
        }
    }


}