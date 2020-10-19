using System;

namespace _6_Tuples
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            var res = MyMethod();

            Print(res);

            //Console.WriteLine($"Name={res.Name}, Number={res.Number}");
        }

        static (string Name, int Number) MyMethod()
        {
            return ("Hello", 123);
        }

        static void Print((string Name, int Number) x)
        {
            Console.WriteLine($"Name={x.Name}, Number={x.Number}");
        }
    }
}
