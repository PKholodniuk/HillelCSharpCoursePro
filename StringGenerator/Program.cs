using System;

namespace StringGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter symbols for generating random string");
            var str = Console.ReadLine();

            Console.WriteLine("Enter number symbols of random string");
            var enteredNumber = Console.ReadLine();

            var quntity = int.Parse(enteredNumber);

            var result = StringGenerators.GeneratRandomString(quntity, str);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
