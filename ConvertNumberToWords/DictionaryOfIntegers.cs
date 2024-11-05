using System.Collections.Generic;
using System.Linq;

namespace ConvertNumberToWords
{
    public class DictionaryOfIntegers
    {
        public static Dictionary<int, string> GetDictionary(int number)
        { 
            Dictionary<int, string> numbersWithWords = new Dictionary<int, string>();
            numbersWithWords.Add(0, "zero");
            numbersWithWords.Add(1, "one");
            numbersWithWords.Add(2, "two");
            numbersWithWords.Add(3, "three");
            numbersWithWords.Add(4, "four");
            numbersWithWords.Add(5, "five");
            numbersWithWords.Add(6, "six");
            numbersWithWords.Add(7, "seven");
            numbersWithWords.Add(8, "eight");
            numbersWithWords.Add(9, "nine");
            numbersWithWords.Add(10, "ten");
            numbersWithWords.Add(11, "eleven");
            numbersWithWords.Add(12, "twelve");
            numbersWithWords.Add(13, "thirteen");
            numbersWithWords.Add(14, "fourteen");
            numbersWithWords.Add(15, "fifteen");
            numbersWithWords.Add(16, "sixteen");
            numbersWithWords.Add(17, "seventeen");
            numbersWithWords.Add(18, "eighteen");
            numbersWithWords.Add(19, "nineteen");
            numbersWithWords.Add(20, "twenty");
            numbersWithWords.Add(30, "thirty");
            numbersWithWords.Add(40, "forty");
            numbersWithWords.Add(50, "fifty");
            numbersWithWords.Add(60, "sixty");
            numbersWithWords.Add(70, "seventy");
            numbersWithWords.Add(80, "eighty");
            numbersWithWords.Add(90, "ninety");

            numbersWithWords = CreateWords(number, numbersWithWords);

            return numbersWithWords;
        }

        private static Dictionary<int, string> CreateWords(int i, Dictionary<int, string> dictionary)
        {
            if (i < 100)
            {
                return ReturnDozens(i, dictionary);
            }

            if (i >= 100 && i < 1000)
            {
                return ReturnHundreds(i, dictionary);
            }

            if (i >= 1000 && i < 1000000)
            {
                return ReturnThousands(i, dictionary);
            }

            if (i >= 1000000 && i < 1000000000)
            {
                return ReturnMillons(i, dictionary);
            }

            if (i >= 1000000000 && i < int.MaxValue)
            {
                return ReturnBillons(i, dictionary);
            }

            return dictionary;
        }

        private static Dictionary<int, string> AddToDictionary(int item, string word, Dictionary<int, string> dictionary)
        {
            if (dictionary.ContainsKey(item))
            {
            }
            else
            {
                dictionary.Add(item, word);
            }

            return dictionary;
        }

        private static Dictionary<int, string> ReturnDozens(int i, Dictionary<int, string> dictionary)
        {
            var firstWord = dictionary.FirstOrDefault(x => x.Key == i - i % 10).Value;
            var secondWord = dictionary.FirstOrDefault(x => x.Key == i % 10).Value;

            if (firstWord != null && secondWord != null)
            {
                var word = $"{firstWord} {secondWord}";

                dictionary = AddToDictionary(i, word, dictionary);
            }

            return dictionary;
        }

        private static Dictionary<int, string> ReturnHundreds(int i, Dictionary<int, string> dictionary)
        {
            var firstWord = "";
            var secondWord = "";
            var word = "";

            dictionary = ReturnDozens(i / 100, dictionary);
            firstWord = dictionary.First(x => x.Key == i / 100).Value;

            if (i % 100 != 0)
            {
                dictionary = ReturnDozens(i % 100, dictionary);
                secondWord = dictionary.FirstOrDefault(x => x.Key == i % 100).Value;
            }

            if (firstWord != "")
            {
                word = $"{firstWord} hundred {secondWord}";
                dictionary = AddToDictionary(i, word, dictionary);
            }
            else
            {
                if (secondWord != "")
                {
                    word = $"{secondWord}";
                    dictionary = AddToDictionary(i, word, dictionary);
                }
            }

            return dictionary;
        }

        private static Dictionary<int, string> ReturnThousands(int i, Dictionary<int, string> dictionary)
        {
            var firstWord = "";
            var secondWord = "";
            var word = "";

            dictionary = ReturnHundreds(i / 1000, dictionary);
            firstWord = dictionary.FirstOrDefault(x => x.Key == i / 1000).Value;

            if (i % 1000 != 0)
            {
                dictionary = ReturnHundreds(i % 1000, dictionary);
                secondWord = dictionary.FirstOrDefault(x => x.Key == i % 1000).Value;
            }

            if (firstWord != "")
            {
                word = $"{firstWord} thousand {secondWord}";
                dictionary = AddToDictionary(i, word, dictionary);
            }
            else
            {
                if (secondWord != "")
                {
                    word = $"{secondWord}";
                    dictionary = AddToDictionary(i, word, dictionary);
                }
            }

            return dictionary;
        }

        private static Dictionary<int, string> ReturnMillons(int i, Dictionary<int, string> dictionary)
        {
            var word = "";
            
            dictionary = ReturnHundreds(i / 1000000, dictionary);
            var firstWord = dictionary.FirstOrDefault(x => x.Key == i / 1000000).Value;

            if (i % 1000000 != 0)
            {
                dictionary = ReturnThousands(i % 1000000, dictionary);
            }

            var secondWord = dictionary.FirstOrDefault(x => x.Key == i % 1000000 && i % 1000000 != 0).Value;

            if (firstWord == null)
            {
                word = $"{secondWord}";
            }
            else
            {
                word = $"{firstWord} million {secondWord}";
            }

            dictionary = AddToDictionary(i, word, dictionary);

            return dictionary;
        }

        private static Dictionary<int, string> ReturnBillons(int i, Dictionary<int, string> dictionary)
        {
            var firstWord = dictionary.FirstOrDefault(x => x.Key == i / 1000_000_000).Value;

            if (i % 1000000 != 0)
            {
                dictionary = ReturnMillons(i % 1000000, dictionary);
            }

            var secondWord = dictionary.FirstOrDefault(x => x.Key == i % 1000000 && i % 1000000 != 0).Value;

            var word = $"{firstWord} billion {secondWord}";

            dictionary = AddToDictionary(i, word, dictionary);

            return dictionary;
        }
    }
}
