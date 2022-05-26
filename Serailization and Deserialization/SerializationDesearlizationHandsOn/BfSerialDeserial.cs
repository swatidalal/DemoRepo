using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;


namespace SerializationDesearlizationHandsOn
{
    internal class BfSerialDeserial
    {
        
        public void Serialize()
        {
            String myString = "Hello ..I am Swati Dalal, I am from Bahadurgarh Haryana";

            // Create file to save the data.
            FileStream fileStream = new FileStream(@"C:\Users\LENOVO\Desktop\Training\SerialDeserial\MyDataInBinaryFormat.txt", FileMode.Create);

            // BinaryFormatter object will perform the serialization
            BinaryFormatter bf = new BinaryFormatter();

            // Serialize() method serializes the data to the file
            bf.Serialize(fileStream, myString);

            fileStream.Close();

        }

       public void Deserialization()
        {
            String myString = "";

            // open file to read data
            FileStream fileStream = new FileStream(@"C:\Users\LENOVO\Desktop\Training\SerialDeserial\MyDataInBinaryFormat.txt", FileMode.Open);

            // BinaryFormatter object will perform the Deserialization
            BinaryFormatter bf = new BinaryFormatter();

            // Deserialize() method Deserializes the data to the file
            myString = (string)bf.Deserialize(fileStream);
            fileStream.Close();

            Console.WriteLine("Your deserialize data is:");
            Console.WriteLine(myString);
        }
    }
}
