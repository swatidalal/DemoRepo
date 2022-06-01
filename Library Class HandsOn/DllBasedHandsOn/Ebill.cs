using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllBasedHandsOn
{
   
    public class EBill
    {
        int CustomerId { get; set; }
        string CustomerName { get; set; }
        int Age { get; set; }
        string PhoneNo { get; set; }
        int NoOfUnits { get; set; }
        int PerUnitCost { get; set; } = 20;
        int Total { get; set; }


        List<EBill> listObj = new List<EBill>();
        
        public void AddDetails()
        {
            Console.WriteLine("Customer details");
            listObj.Add(new EBill
            {
                CustomerId = 1001,
                CustomerName = "Swati Dalal",
                Age = 22,
                PhoneNo = "3246572466",
                NoOfUnits = 100,
                //PerUnitCost = 20,
                Total = NoOfUnits*20

            });
            listObj.Add(new EBill
            {
                CustomerId = 1002,
                CustomerName = "riya",
                Age = 24,
                PhoneNo = "645843q4645",
                NoOfUnits = 150,
                //PerUnitCost = 50,
                Total = NoOfUnits * 20

            }) ;
            listObj.Add(new EBill
            {
                CustomerId = 1003,
                CustomerName = "naveen",
                Age = 35,
                PhoneNo = "36979542",
                NoOfUnits = 15,
                //PerUnitCost = 20,
                Total = NoOfUnits * 20

            });
            listObj.Add(new EBill
            {
                CustomerId = 1004,
                CustomerName = "Sia kumari",
                Age = 50,
                PhoneNo = "795580",
                NoOfUnits = 100,
               // PerUnitCost = 30,
                Total = NoOfUnits *20

            });
            listObj.Add(new EBill
            {
                CustomerId = 1005,
                CustomerName = "jyoti",
                Age = 22,
                PhoneNo = "3877887",
                NoOfUnits = 200,
               // PerUnitCost = 20,
                Total = NoOfUnits * 20

            });


            listObj.Add(new EBill
            {
                CustomerId = 1006,
                CustomerName = "Mahi Dalal",
                Age = 15,
                PhoneNo = "46807526",
                NoOfUnits = 40,
                //PerUnitCost = 20,
                Total = NoOfUnits * 20

            });

            listObj.Add(new EBill
            {
                CustomerId = 1007,
                CustomerName = "raj",
                Age = 49,
                PhoneNo = "34354724265",
                NoOfUnits = 67,
               // PerUnitCost = 10,
                Total = NoOfUnits * 20

            });
            listObj.Add(new EBill
            {
                CustomerId = 1008,
                CustomerName = "kiran",
                Age = 35,
                PhoneNo = "3246572466",
                NoOfUnits = 10,
               // PerUnitCost = 200,
                Total = NoOfUnits * 20

            });
            listObj.Add(new EBill
            {
                CustomerId = 1009,
                CustomerName = "Suman",
                Age = 19,
                PhoneNo = "4554365476",
                NoOfUnits = 100,
                //PerUnitCost = 20,
                Total = NoOfUnits * 20

            });
            listObj.Add(new EBill
            {
                CustomerId = 1010,
                CustomerName = "Sonu",
                Age = 39,
                PhoneNo = "354578",
                NoOfUnits = 2,
                //PerUnitCost = 2000,
                Total = NoOfUnits * 20

            });
            for (int i = 0; i < listObj.Count; i++)
            {
                //if (iD == listObj[i].CustomerId)
                //{
                    Console.WriteLine(listObj[i].NoOfUnits + " " + listObj[i].Total);
                //    break;
                //}
            }
        }

        public void ShowCustomerDetails(int iD)
        {
            for (int i = 0; i < listObj.Count; i++)
            {
                if (iD == listObj[i].CustomerId)
                {
                    Console.WriteLine(listObj[i].CustomerId + " " + listObj[i].CustomerName + " "  + " " + listObj[i].PhoneNo + " "
                        + listObj[i].Age);
                    break;
                }
            }
            return;
        }
        public void ShowEBill(int iD)
        {
            for (int i = 0; i < listObj.Count; i++)
            {
                if (iD == listObj[i].CustomerId)
                {
                    Console.WriteLine(listObj[i].NoOfUnits + " " + listObj[i].Total);
                    break;
                }
            }
            return;
        }
        public void ShowEBillReport()
        {
            for (int i = 0; i < listObj.Count; i++)
            {
                Console.WriteLine(listObj[i].CustomerId + " " + " " + listObj[i].CustomerName + " " + " " + listObj[i].PhoneNo + " "
                      + " " + listObj[i].Age +" "+ listObj[i].NoOfUnits + " " + " " + listObj[i].Total);
            }
            return;
        }

    }






}

