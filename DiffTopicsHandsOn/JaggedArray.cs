using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffTopicsHandsOn
{
    internal class JaggedArray
    {
        public void jArray()
        {
            string[][] Employee= new string[4][]{  
               new string[]{"Riya", "Samer", "Aliya"},  
               new string[]{"Priya", "Sonia", "Preety", "Romy", "Divya"},  
            new string[]{"Yogita", "Jonika", "Sandeep", "siya", "Tiya", "Shalu"},  
            new string[]{"Teena", "Mahi", "Arju", "Swati", "Golddy", "Samy", "Lisha"},  
                };  
            for (int i = 0; i < Employee.Length; i++)  
            {  
                System.Console.Write("Name List ({0}): ", i + 1);  
                for (int j = 0; j < Employee[i].Length; j++)  
                {  
                    System.Console.Write(Employee[i][j] + "\t");  
                }  
                System.Console.WriteLine();  
            }  
            //Console.ReadKey();
        }
    }
}
