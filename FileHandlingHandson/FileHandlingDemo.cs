using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingHandson
{
    public class FileHandlingDemo
    {
        public void Readfile()
        {
            FileStream fileStreamobj = new FileStream("C:\\Users\\LENOVO\\Desktop\\Training\\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("Id\tSource\t\tDestination\tDate\t\tTime\tStatus\tNetwork");
            while (streamReaderobj.Peek() > 0)
            {
                string line = streamReaderobj.ReadLine();

                if (line != "")
                {
                    if (line.StartsWith("Date"))
                    {
                        string[] nLine1 = line.Split(' ');
                        string[] nLine2 = nLine1[0].Split(':');
                        Console.Write(nLine2[1] + "\t" + nLine1[1] + "\t");
                        continue;
                    }
                    string[] nLine = line.Split(':');
                    Console.Write(nLine[1] + "\t");
                }
                else
                {
                    Console.WriteLine();
                }
            }   



            }
    }
}
