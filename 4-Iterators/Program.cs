using System;
using System.Collections.Generic;

namespace _4_Iterators
{
    class Program
    {
        static IEnumerable<int> GetNumbers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }

        static IEnumerable<int> OddNumbers()
        {
            int i = 0;
            while (true)
            {
                if (i % 2 != 0)
                    yield return i;
                i++;
            }
        }

        static void Main(string[] args)
        {
            int count = 1;
            foreach (var number in OddNumbers())
            {
                Console.WriteLine(number);
                if (count++ > 9) break;
            }

            //var numbers = new int[]{1,2,3,4,5};

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //var enumerator = numbers.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}
        }
    }
}
