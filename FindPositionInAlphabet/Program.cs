using System;

namespace FindPositionInAlphabet
{
    internal class Program
    {
        static bool isEnglishLetter;
        static bool length;
        static string letter;
        static bool doWhile;

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter English letter:");
                letter = Console.ReadLine();
                
                length = letter.Length == 1;
                isEnglishLetter = letter[0].IsEnglishLetter();
                doWhile = isEnglishLetter && length;

                if (doWhile)
                {
                    var indexerOfAlphabet = letter[0].ReturnPositionInEnglishAlphabet();

                    Console.WriteLine($"Your letter: {letter} has position: {indexerOfAlphabet} in English alphabet");

                    if (letter[0].ToString() == letter[0].ToString().ToLower())
                    {
                        Console.WriteLine($"Your letter: {letter} looks: {letter[0].ToString().ToUpper()} in another register");
                    }
                    else
                    {
                        Console.WriteLine($"Your letter: {letter} looks: {letter[0].ToString().ToLower()} in another register");
                    }
                }
                else
                {
                    Console.WriteLine("You entered more then one symbol or is not English letter.");
                }

            } while (!doWhile);

            Console.ReadLine();
        }
    }
}
