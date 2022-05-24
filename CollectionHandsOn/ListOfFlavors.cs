using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHandsOn
{
    
    public class ListOfFlavors
    {
        public void Data()
        {

            List<String> IceCreamFlavors = new List<String>();

            IceCreamFlavors.Add("Vanilla");
            IceCreamFlavors.Add("Chocolate");
            IceCreamFlavors.Add("Strawberry");
            IceCreamFlavors.Add("Kulfi");
            IceCreamFlavors.Add("Mango");
            IceCreamFlavors.Add("Vanilla");
            IceCreamFlavors.Add("KesarPista");


           

            for (int i = 0; i < IceCreamFlavors.Count; i++)
            {
                var flavor = IceCreamFlavors[i];
                Console.WriteLine(flavor);
            }
            Console.WriteLine();
            Console.WriteLine($"Before removing 3rd element:{IceCreamFlavors.Count}");
            Console.WriteLine();

            //Removing 3rd element from list
            IceCreamFlavors.RemoveAt(2);

            for (int i = 0; i < IceCreamFlavors.Count; i++)
            {
                var flavor = IceCreamFlavors[i];
                Console.WriteLine(flavor);
            }
            Console.WriteLine($"After removing 3rd element at Index 2:{IceCreamFlavors.Count}");



        }
    }
    
}
