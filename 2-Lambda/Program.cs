using System;

namespace _2_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> fn = Cube;

            //Console.WriteLine(fn.Invoke(5));

            var numbers = new int[] {1, 2, 3, 4, 5};

            var fn2 = CreateFn();

            MyLoop(numbers, fn2);

        }

        static Func<int, int> CreateFn()
        {
            int i = 23;
            return x => x * i;
        }

        static void MyLoop(int[] array, Func<int, int> fn)
        {
            foreach (var i in array)
            {
                Console.WriteLine(fn(i));
            }
        }

        static int Square(int x)
        {
            return x * x;
        }

        static int Cube(int x)
        {
            return x * x * x;
        }
    }
}
