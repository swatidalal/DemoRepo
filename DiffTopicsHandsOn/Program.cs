
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DiffTopicsHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jagged array
            Console.WriteLine("Jagged Array:-");
            JaggedArray Ja = new JaggedArray();
            Ja.jArray();

            Console.WriteLine();

            //Ref and Out
            Console.WriteLine("REFandOut Demo:-");
            RefAndOut refAndOut = new RefAndOut();
            Console.WriteLine("Ref");
            refAndOut.RefFunction();
            Console.WriteLine("Out");
            refAndOut.OutFunction();
            Console.WriteLine();

            //performed Checked And Unchecked

            Console.WriteLine("Checked and Unchecked Keyword:-");
            Checked_Unchecked checked_Unchecked = new Checked_Unchecked();
            //checked_Unchecked.CheckedKeyword();
            checked_Unchecked.UncheckedKeyword();

            Console.WriteLine();

            //struct
            Console.WriteLine("Struct And Classes:-");
            UsingStruct usingStruct = new UsingStruct();
            usingStruct.PerFormStruct();
            usingStruct.StructCanNotBeNullAssign();

            Console.WriteLine();

            //Nullable 
            Console.WriteLine("Null Keyword:-");
            NullableDemo nullableDemo = new NullableDemo();
            nullableDemo.PerformNullableExample();
            Console.WriteLine();


            // nested classes
            Console.WriteLine("Nested Classes:-");
            NestedClasses.Outer_class.Inner_class inner_Class = new NestedClasses.Outer_class.Inner_class();
            inner_Class.Method1();
            Console.WriteLine();

            //Method hiding
            Console.WriteLine("Method Hiding:-");
            My_Member obj = new My_Member();
            obj.member();
            Console.WriteLine();


            //tuples
            Console.WriteLine("Tupples:-");
            Tupples tup = new Tupples() ;
            tup.PerformTupleExample();
            Console.ReadLine();
    }

            





        }
 }


