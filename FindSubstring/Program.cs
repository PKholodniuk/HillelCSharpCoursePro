using System;

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
                Console.WriteLine($"You entered: \"{substring}\" " +
                        $"and this substring is in the text");
            }
            else
            {
                Console.WriteLine("There is no substring in the text");
            }

            Console.ReadLine();
        }
    }
}
