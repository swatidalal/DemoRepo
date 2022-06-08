using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandsOn
{
    public class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        public Person(string Fname, string Lname, int Age)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.Age = Age;
        }
    }
    public class LinqPrg7
    {


        public void LastNameWithD()
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
            foreach (var n in people)
            {
                Console.WriteLine("First Name : {0}\t Last Name : {1}\t Age : {2}", n.Fname, n.Lname, n.Age);
            }
            Console.Write("Enter a character to fine all lastname which start from that character: ");
            String s = Console.ReadLine();
            var res = (from peopleItem in people
                       where peopleItem.Lname.StartsWith(s)
                       select peopleItem.Lname).ToList();
            foreach (var resultitem in res)
            {
                Console.WriteLine(resultitem);
            }

            //8.	Number of people whose last name starts with the letter D
            Console.WriteLine($"Number of people whose name startswith {s} are: {res.Count()}");



        }
    }
}

