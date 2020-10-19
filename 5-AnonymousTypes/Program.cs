using System;

namespace _5_AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            var s = new {Name = "Peter", Age = 23};

            var x = CreateAnonType();


            Console.WriteLine(x);


        }

        static object CreateAnonType()
        {
            return new {Id = 2, Phone = 123456};
        }
    }
}
