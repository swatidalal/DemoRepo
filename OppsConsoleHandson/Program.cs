using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConsoleHandson
{

    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);

            Users user = new Users("Swati Dalal", 23);
            user.GetUserDetails();
            Console.WriteLine("Press Enter Key to Exit..");
            //Console.ReadLine();


            // create Dog object 
            Dog bullDog = new Dog();

            // access breed of the Dog 
            bullDog.breed = "Bull Dog";
            Console.WriteLine(bullDog.breed);

            // access method of the Dog
            bullDog.bark();

            Console.Read();
        }
    }


}
