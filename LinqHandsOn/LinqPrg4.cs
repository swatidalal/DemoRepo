using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandsOn
{
    internal class LinqPrg4
    {
        public void SpecificChar( )
        {
           List < string > cityLists = new List<string>()
                  {
                      "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEWDELHI","AMSTERDAM","ABUDHABI","PARIS"
                  };

            var displayCityLsit = (from city in cityLists
                                   select city).ToList();

            Console.WriteLine("The cities are :");
            foreach (var city in displayCityLsit)
            {
                Console.Write($"{city} ");
            }
            Console.WriteLine();
            Console.Write("Input starting character for the string :");
            string startWith, endsWith;
            startWith = Console.ReadLine();

            Console.Write("Input ending character for the string :");
            endsWith = Console.ReadLine();

            var resCity = (from city in cityLists
                           where city.StartsWith(startWith) && city.EndsWith(endsWith)
                           select city).FirstOrDefault();

            Console.WriteLine($"The city starting with {startWith} and ending with {endsWith} is :{resCity}");

        }
    }

}
    

