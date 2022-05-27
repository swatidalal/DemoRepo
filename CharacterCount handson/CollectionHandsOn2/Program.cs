using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHandsOn2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CharacterCount countingCharacters = new CharacterCount();
            Console.WriteLine();
            Console.WriteLine("This is with hardCoded String Lorem text:");
            countingCharacters.startCounting("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("This is with user Input :");
            //countingCharacters.UserPrometStringAndCaseInsesative();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" this is with Read A String from a File");
           // countingCharacters.ReadStringfromFile();
            Console.ReadKey();
        }
    }
}