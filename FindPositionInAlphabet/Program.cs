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
                
                char charConsole = letter[0];

                isEnglishLetter = charConsole.IsEnglishLetter();
                
                doWhile = isEnglishLetter && length;

                if (doWhile)
                {
                    var indexerOfAlphabet = charConsole.ReturnPositionInEnglishAlphabet();

                    Console.WriteLine($"Your letter: {letter} has position: {indexerOfAlphabet} in English alphabet");

                    if (charConsole == char.ToLower(charConsole))
                    {
                        Console.WriteLine($"Your letter: {letter} looks: {char.ToUpper(charConsole)} in another register");
                    }
                    else
                    {
                        Console.WriteLine($"Your letter: {letter} looks: {char.ToLower(charConsole)} in another register");
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
