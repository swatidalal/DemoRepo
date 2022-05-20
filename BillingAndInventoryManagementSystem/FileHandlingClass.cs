using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingAndInventoryManagementSystem
{
    public class FileHandlingClass
    {

        public void User_Module()
        {
            FileStream fst = new FileStream(@"C:\Users\LENOVO\Desktop\Training\Users.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fst);
            Console.Write("Enter the UserId:- ");
            sw.Write("user id:- ");
            sw.WriteLine(Console.ReadLine());
            

            Console.Write("Enter the Firstname: ");
            sw.Write("first name:- ");
            sw.WriteLine(Console.ReadLine());
            

            Console.Write("Enter the Lastname: ");
            sw.Write("Last name:- ");
            sw.WriteLine(Console.ReadLine());
            

            Console.Write("Enter the Email: ");
            sw.Write("Email:- ");
            sw.WriteLine(Console.ReadLine());
     

            Console.Write("Enter the Phone: ");
            sw.Write("phone no :-");
            sw.WriteLine(Console.ReadLine());
           
            sw.Close();
            fst.Close();
        }
        public void Category_Module()
        {
            FileStream fobj = new FileStream(@"C:\Users\LENOVO\Desktop\Training\Category.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sobj = new StreamWriter(fobj);
            Console.Write("Enter the CategoryId: ");
            sobj.Write("CAtegory id :- ");
            sobj.WriteLine(Console.ReadLine());
           

            Console.Write("Enter the CategoryType: ");
            sobj.Write("Categorytype:- ");
            sobj.WriteLine(Console.ReadLine());

            sobj.Close();
            fobj.Close();
        }
        public void Product_Module()
        {

            FileStream fobj = new FileStream(@"C:\Users\LENOVO\Desktop\Training\Product.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sobj = new StreamWriter(fobj);
            Console.Write("Enter the Productid: ");
            sobj.Write("Product id:- ");
            sobj.WriteLine(Console.ReadLine());
            

            Console.Write("Enter the categorytype: ");
            sobj.Write("Categorytype:-");
            sobj.WriteLine(Console.ReadLine());
           

            Console.Write("Enter the productname: ");
            sobj.Write("Product name");
            sobj.WriteLine(Console.ReadLine());
          

            Console.Write("Enter the quantity: ");
            sobj.Write("quantity:- ");
            sobj.WriteLine(Console.ReadLine());
           

            Console.Write("Enter the price: ");
            sobj.Write("price:-");
            sobj.WriteLine(Console.ReadLine());
          
            sobj.Close();
            fobj.Close();

        }
        public void Purchase_and_Sales_Module()
        {


            FileStream fobj = new FileStream(@"C:\Users\LENOVO\Desktop\Training\Purchase&Sale.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sobj = new StreamWriter(fobj);
            Console.Write("Enter the SalesId: ");
            sobj.Write("SalesId:- ");
            sobj.WriteLine(Console.ReadLine());
            

            Console.Write("Enter the Productid: ");
            sobj.Write("Productid:-");
            sobj.WriteLine(Console.ReadLine());
            

            Console.Write("Enter the price: ");
            sobj.Write("Price");
            sobj.WriteLine(Console.ReadLine());
            

            Console.Write("Enter the salesdate: ");
            sobj.Write("Salesdate");
            sobj.WriteLine(Console.ReadLine());



            sobj.Close();
            fobj.Close();



        }
    }
}
