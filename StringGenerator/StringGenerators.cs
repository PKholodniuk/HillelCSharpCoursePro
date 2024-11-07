using System;
using System.Text;

namespace StringGenerator
{
    public static class StringGenerators
    {
        public static string GeneratRandomString(int quntity, string str)
        {
            var stringChars = new char[quntity];

            var builder = new StringBuilder();

            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                builder.Append(stringChars[i] = str[random.Next(str.Length)]);
            }

            return builder.ToString();
        }
    }
}
