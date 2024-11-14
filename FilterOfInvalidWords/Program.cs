using System;
using System.Text.RegularExpressions;

namespace FilterOfInvalidWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Mother Fuck, where did you piss with your penis?";

            string[] array = { "bitch", "penis", "fuck", "piss"  };

            for (int i = 0; i < array.Length; i++)
            {
                {
                    text = Regex.Replace(text, Regex.Escape(array[i]), new string('*', array.Length), RegexOptions.IgnoreCase);
                }
            }

            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
