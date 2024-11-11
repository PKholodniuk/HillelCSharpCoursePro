using System;
using System.Linq;
using System.Text;

namespace SplitStringToArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cities = "London, Paris, Rom";

            var citiesArray = SplitStringToArray(cities, ',');

            foreach (var city in citiesArray)
            {
                Console.WriteLine(city);
            }

            Console.ReadLine();
        }

        static string[] SplitStringToArray(string input, char charSplit)
        {
            var countSplitSymbol = input.Where(x => x == charSplit).Count();

            string[] result = new string[countSplitSymbol+1];

            var charArray = input.ToCharArray();

            var builder = new StringBuilder();

            int j = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == charSplit)
                {
                    result[j] = builder.ToString();
                    j++;
                    builder.Clear();
                    continue;
                }
                else
                {
                    builder.Append(charArray[i]);

                    if (i == charArray.Length-1)
                    {
                        result[j] = builder.ToString();
                    }
                }
            }

            return result;
        }
    }
}
