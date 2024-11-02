using System.Collections.Generic;
using System.Linq;

namespace FindPositionInAlphabet
{
    public static class ExtensionChar
    {
        internal static List<char> GetListOfEnglishLetters = Enumerable.Range('a', 26).Select(n => (char)n).ToList();

        public static bool IsEnglishLetter(this char letter)
        {
            bool isEnglishLetter = GetListOfEnglishLetters.Any(x => x.ToString().Equals(letter.ToString().ToLower()));

            return isEnglishLetter;
        }

        public static int ReturnPositionInEnglishAlphabet(this char letter)
        {
            var indexerOfAlphabet = GetListOfEnglishLetters.FindIndex(x => x.Equals(letter.ToString().ToLower()[0]));
            var positionInAlphabet = indexerOfAlphabet + 1;
            return positionInAlphabet;
        }
    }
}
