using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandsOn
{
    public class LinQPrg9
    {
        public void DescFirstName()
        {
            var people = new List<Person>()
        {
            new Person("Bill", "Smith", 41),
            new Person("Sarah", "Jones", 22),
            new Person("Stacy","Baker", 21),
            new Person("Vivianne","Dexter", 19 ),
            new Person("Bob","Smith", 49 ),
            new Person("Brett","Baker", 51 ),
            new Person("Mark","Parker", 19),
            new Person("Alice","Thompson", 18),
            new Person("Evelyn","Thompson", 58 ),
            new Person("Mort","Martin", 58),
            new Person("Eugene","DeLauter", 84 ),
            new Person("Gail","Dawson", 19 ),

        };

            var resdescName = (from peopleItem in people
                           where peopleItem.Age > 40
                           orderby peopleItem.Fname descending
                           select peopleItem.Fname).ToList();


            foreach (var resultitem in resdescName)
            {
                Console.Write($"{resultitem}, ");
            }
        }
    }
}
