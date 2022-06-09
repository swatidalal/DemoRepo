using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Author author = new Author();
            //author.InsertAuthor();
             Book book = new Book();
            book.InsertBook();
            
            Console.ReadLine();
        }
    }
}
