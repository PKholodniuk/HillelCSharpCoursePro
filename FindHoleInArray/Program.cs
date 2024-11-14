using System;
using System.Linq;

namespace FindHoleInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 2, 3, 4, 5, 6, 8, 9 };
            
            WriteResult(FindHoleInArray(ints));

            int[] ints2 = { 2, 3, 4, 5 };

            WriteResult(FindHoleInArray(ints2));

            Console.ReadLine();
        }

        private static int? FindHoleInArray(int [] array)
        {
            int? number = null;

            array.OrderBy(x => x);

            if (array[array.Length-1] - array[0] == array.Length-1)
            {
                return number;
            }

            for (int i = 0; i <= array.Length; i++)
            {
                if (array[i+1] - array[i] != 1)
                {
                    return number = array[i]+1; ;
                }
            }

            return number;
        }

        private static void WriteResult(int? result)
        {
            if (result.HasValue)
            {
                Console.WriteLine($"The hole in array is: {result}");
            }
            else
            {
                Console.WriteLine("There is no hole in the array");
            }
        }
    }
}
