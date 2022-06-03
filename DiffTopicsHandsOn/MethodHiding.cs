using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffTopicsHandsOn
{
    public class MethodHiding

    {
        

            public void member()
            {
                Console.WriteLine("Total number of family members: 3");
            }
        }

        // Derived Class
        public class My_Member : MethodHiding
        {

            // Reimplement the method of the base class
            // Using new keyword
            // It hides the method of the base class
            public new void member()
            {
                Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya, " +
                                       "Age: 39 \nName: Rohan, Age: 20 ");
            }
        }

    }

