using System;
using System.Linq;

namespace ConvertNumberToWords
{
    internal class Program
    {
        static int getNumber = 0;

        static void Main(string[] args)
        {
            int maxInteger = int.MaxValue;

            Console.WriteLine($"Enter integer from: 0 to: {maxInteger} ");

            var enteredValue = Console.ReadLine();

            try
            {
                getNumber = int.Parse(enteredValue);
            }
            catch (Exception)
            {
                Console.WriteLine("You entered wrong number!!! Good buy");

                throw new Exception("User entered wrong number!!! Good buy");
            }

            var dictionaryOfIntegers = DictionaryOfIntegers.GetDictionary(getNumber);

            var getWordsFromNumber = dictionaryOfIntegers.FirstOrDefault(x => x.Key == getNumber).Value;

            Console.WriteLine($"Your number: {enteredValue} converted to words: {getWordsFromNumber}");
            
            Console.Read();
        }         
    }   
}
