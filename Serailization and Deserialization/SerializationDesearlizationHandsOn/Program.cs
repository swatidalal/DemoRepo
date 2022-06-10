using SerializationDesearlizationHandsOn;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Newtonsoft.Json;

namespace SerializationDesearlizationHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //XmlSerialDeserial xmlFormatSerialization = new XmlSerialDeserial();
            //xmlFormatSerialization.SerializeInXmlFormat();
            //xmlFormatSerialization.DeSerializeFromXmlFormatToListEBill();

            JsonSerialDeserial jsonFormatSerialization = new JsonSerialDeserial();
             string result=jsonFormatSerialization.SerializeInJsonFromat();
            jsonFormatSerialization.DeSerializeFromJsonFromatToListEBill(result);

            //BfSerialDeserial serialization = new BfSerialDeserial();
            //serialization.Serialize();

            //BfSerialDeserial deserialize = new BfSerialDeserial();
            //deserialize.Deserialization();
        }
    }
}