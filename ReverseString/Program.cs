using System;
using System.Linq;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");

            string str = Console.ReadLine();

            var newString =  ReverseString(str);

            Console.WriteLine($"Your text is reverted in this: {newString}");
            Console.ReadLine();
        }
         
        
        static string ReverseString(string str)
        {
            var charArray = str.ToArray();

            for (int i = 0; i < str.Length /2; i++)
            {
                char tmp = charArray[i];
                charArray[i] = charArray[charArray.Length - i - 1];
                charArray[charArray.Length - i - 1] = tmp;
            }

            str = string.Join("", charArray);

            return str;
        }
    }
}
