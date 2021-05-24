using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_03_value_and_ref_types
{


    public struct Struct
    {
       public int x;
       public int y;
    }

    public class MyClass
    {
        public int x;
        public int y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Struct struct1 = new Struct();
            Struct struct2 = new Struct();

            struct2.x = 10;
            struct2.y = 12;

            struct1 = struct2;
            struct2.x = 5;

            Console.WriteLine(struct1.x);
            Console.WriteLine(struct1.y);
            Console.WriteLine(struct2.x);
            Console.WriteLine(struct2.y);


            //MyClass myClass1 = new MyClass();
            //MyClass myClass2 = new MyClass();

            //myClass2.x = 10;
            //myClass2.y = 11;

            //myClass1 = myClass2;

            //myClass1.x = 1;
            //myClass2.y = 2;

            //Console.WriteLine($"myClass1.x: { myClass1.x}");
            //Console.WriteLine($"myClass1.y: { myClass1.y}");
            //Console.WriteLine($"myClass2.x: { myClass2.x}");
            //Console.WriteLine($"myClass2.y: { myClass2.y}");
        }
    }
}
