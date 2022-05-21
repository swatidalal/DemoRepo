using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPSConsoleHandson
{

    public class Users
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Users(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void GetUserDetails()
        {
            Console.WriteLine("Name: {0}, Age: {1}", Name, Age);
        }
    }
}
