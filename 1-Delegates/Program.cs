using System;

namespace _1_Delegates
{
    class Program
    {
        //delegate int MyDelegate(int x);
        static void Main(string[] args)
        {

            Func<int,int> fn = Cube;

            //Console.WriteLine(fn.Invoke(5));

            var numbers = new int[] {1, 2, 3, 4, 5};

            MyLoop(numbers, Square);

            //Action<int[], Func<int, int>> func = MyLoop;

            //func(numbers, Cube);

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
