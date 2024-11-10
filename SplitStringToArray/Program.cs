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
                    j++;
                    builder = new StringBuilder();
                    continue;
                }
                else
                {
                    result[j] = builder.Append(charArray[i]).ToString();
                }
            }

            return result;
        }
    }
}
