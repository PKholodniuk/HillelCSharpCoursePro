using System;
using System.Collections.Generic;

namespace FindSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "The distance is nothing when one has a motive to achieve the goal.";

            Console.WriteLine("Enter words for finding substring and its indexes");

            string substring = Console.ReadLine();

            bool result = text.Contains(substring);

            if (result)
            {
                var r = FindFirstIndexOfSubstring(text, substring);

                var getSubstring = text.Substring(r[0], substring.Length);

                Console.WriteLine($"You entered: \"{getSubstring}\" " +
                        $"and first substring starts from index: {r[0]} and ends index: {r[0] + substring.Length}");
            }
            else
            {
                Console.WriteLine("There is no substring in the text");
            }

            Console.ReadLine();
        }

        static List<int> FindFirstIndexOfSubstring(string text, string searchSubstring)
        {
            List<int> positions = new List<int>();

            var index = text.IndexOf(searchSubstring);

            while (index != -1)
            {
                positions.Add(index);
                index = text.IndexOf(searchSubstring, index + 1);
            }

            return positions;
        }
    }
}
