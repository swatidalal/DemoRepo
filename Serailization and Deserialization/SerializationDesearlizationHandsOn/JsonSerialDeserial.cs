using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Xml;


namespace SerializationDesearlizationHandsOn
{
    internal class EBill
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int NoOfUnits { get; set; }
        public int UnitPerCost { get; set; } = 7;
        public int Total { get; set; }

    }
    public class JsonSerialDeserial
    {

        public void SerializeInJsonFromat()
        {
            //to store customers details of type EBill class
            List<EBill> list = new List<EBill>();


            Console.WriteLine("Enter no. of EBill objects you want to store.");
            int totalCustomers = Convert.ToInt32(Console.ReadLine());

            //initializing EBill details from inputs
            for (int i = 0; i < totalCustomers; i++)
            {
                EBill ebillObj = new EBill();
                Console.WriteLine("Enter Customer Id.");
                ebillObj.CustomerId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Customer name");
                ebillObj.CustomerName = (Console.ReadLine());

                Console.WriteLine("Enter No of units");
                ebillObj.NoOfUnits = Convert.ToInt32(Console.ReadLine());

                ebillObj.Total = 7 * ebillObj.NoOfUnits;

                list.Add(ebillObj);
            }

            using (StreamWriter file = File.AppendText(@"C:\Users\LENOVO\Desktop\Training\SerialDeserial\MyDataInJsonFormat.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, list);
            }

        }

        public void DeSerializeFromJsonFromatToListEBill()
        {
            //creating an empty list 
            List<EBill> list = new List<EBill>();

            using (StreamReader file = File.OpenText(@"C:\Users\LENOVO\Desktop\Training\SerialDeserial\MyDataInJsonFormat.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                list = (List<EBill>)serializer.Deserialize(file, typeof(List<EBill>));
            }

            foreach (EBill ebill in list)
            {
                Console.WriteLine(ebill.CustomerId + " " + ebill.CustomerName + " " + ebill.NoOfUnits + " " + ebill.Total);
            }
            Console.WriteLine(list.Count);
        }
    }

    public class XmlSerialDeserial
    {
        public void SerializeInXmlFormat()
        {
            //to store customers details of type EBill class
            List<EBill> list = new List<EBill>();

            Console.WriteLine("Enter no. of customers data you want to store.");
            int totalCustomers = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < totalCustomers; i++)
            {
                EBill ebillObj = new EBill();
                Console.WriteLine("Enter Customer Id.");
                ebillObj.CustomerId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Customer name");
                ebillObj.CustomerName = (Console.ReadLine());

                Console.WriteLine("Enter No of units");
                ebillObj.NoOfUnits = Convert.ToInt32(Console.ReadLine());

                ebillObj.Total = 7 * ebillObj.NoOfUnits;

                list.Add(ebillObj);
            }


            FileStream fileStream = new FileStream(@"C:\Users\LENOVO\Desktop\Training\SerialDeserial\MyDataInXmlFormat.txt", FileMode.Append, FileAccess.Write);

            XmlSerializer serializer = new XmlSerializer(typeof(List<EBill>));


            serializer.Serialize(fileStream, list);
            fileStream.Close();


        }

        public void DeSerializeFromXmlFormatToListEBill()
        {

            FileStream fileStreamobjForDe = new FileStream(@"C:\Users\LENOVO\Desktop\Training\SerialDeserial\MyDataInXmlFormat.txt", FileMode.Open);


            XmlSerializer Dserializer = new XmlSerializer(typeof(List<EBill>));

            List<EBill> newList = (List<EBill>)Dserializer.Deserialize(fileStreamobjForDe);

            //using (XmlReader reader = XmlReader.(@"C:\Users\LENOVO\Desktop\Training\SerialDeserial\MyDataInXmlFormat.txt"))
            //{
            //    list = (List<EBill>)ser.Deserialize(reader);
            //}

            foreach (EBill ebill in newList)
            {
                Console.WriteLine(ebill.CustomerId + " " + ebill.CustomerName + " " + ebill.NoOfUnits + " " + ebill.Total);
            }

        }



    }

}
