using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;


namespace CollectionHandsOn2
{
    public class CharacterCount
    {
        public Dictionary<char, int> charactersCount = new Dictionary<char, int>();
        public void startCounting(string getString)
        {

            char[] chars = getString.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < chars.Length; j++)
                {
                    if (chars[i] == chars[j])
                    {
                        count++;

                    }
                }
                if (!charactersCount.ContainsKey(chars[i]))
                {
                    charactersCount.Add(chars[i], count);

                }
            }
            foreach (KeyValuePair<char, int> author in charactersCount)
            {
                Console.WriteLine("{0}:{1}", author.Key, author.Value);

            }
            charactersCount.Clear();



        }
        //public void UserPrometStringAndCaseInsesative()
        //{
        //    Console.WriteLine("Enter the a String");
        //    string getstring = Console.ReadLine();

        //    getstring = ExcludeNonAlphabets(getstring);

        //    startCounting(getstring);


        }
        //public void ReadStringfromFile()
        //{
        //    FileStream fileStream = new FileStream(@"C:\Users\LENOVO\Desktop\Training\StringFile.txt", FileMode.Open, FileAccess.Read);
        //    StreamReader sr = new StreamReader(fileStream);
        //    string str = sr.ReadToEnd();
        //    str = ExcludeNonAlphabets(str);
        //    startCounting(str);

        //    sr.Dispose();
        //    sr.Close();
        //    fileStream.Close();


        //}
        //public string ExcludeNonAlphabets(string getstring)
        //{


        //    string str = "";
        //    getstring = getstring.ToLower();
        //    char[] chars = getstring.ToCharArray();
        //    for (int i = 0; i < chars.Length; i++)
        //    {
        //        if (char.IsLetter(chars[i]))
        //        {
        //            str += chars[i].ToString();
        //        }

        //    }

        //    return str;

        }

    }
}