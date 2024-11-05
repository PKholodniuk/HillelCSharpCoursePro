using NUnit.Framework;
using ConvertNumberToWords;
using System.Linq;

namespace UnitTestsHillelCourseComponent
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class DictionaryOfIntegersTest
    {
        [TestCase(0)]
        public void ZeroCheckDictionaryTest(int number)
        {
            var isEnglishLetter = DictionaryOfIntegers.GetDictionary(number);
            var getWordsFromNumber = isEnglishLetter.FirstOrDefault(x => x.Key == number).Value;
            Assert.AreEqual("zero", getWordsFromNumber);
        }

        [TestCase(42)]
        public void DozensCheckDictionaryTest(int number)
        {
            var isEnglishLetter = DictionaryOfIntegers.GetDictionary(number);
            var getWordsFromNumber = isEnglishLetter.FirstOrDefault(x => x.Key == number).Value;
            Assert.AreEqual("forty two", getWordsFromNumber);
        }

        [TestCase(1000001)]
        public void OneMillionOneCheckDictionaryTest(int number)
        {
            var isEnglishLetter = DictionaryOfIntegers.GetDictionary(number);
            var getWordsFromNumber = isEnglishLetter.FirstOrDefault(x => x.Key == number).Value;
            Assert.AreEqual("one million one", getWordsFromNumber);
        }

        [TestCase(100101059)]
        public void NotSimpleNumberCheckDictionaryTest(int number)
        {
            var isEnglishLetter = DictionaryOfIntegers.GetDictionary(number);
            var getWordsFromNumber = isEnglishLetter.FirstOrDefault(x => x.Key == number).Value;
            Assert.AreEqual("one hundred  million one hundred one thousand fifty nine", getWordsFromNumber);
        }

        [TestCase(145002021)]
        public void CompoundNumberCheckDictionaryTest(int number)
        {
            var isEnglishLetter = DictionaryOfIntegers.GetDictionary(number);
            var getWordsFromNumber = isEnglishLetter.FirstOrDefault(x => x.Key == number).Value;
            Assert.AreEqual("one hundred forty five million two thousand twenty one", getWordsFromNumber);
        }

        [TestCase(1_000_000_000)]
        public void OneBillionCheckDictionaryTest(int number)
        {
            var isEnglishLetter = DictionaryOfIntegers.GetDictionary(number);
            var getWordsFromNumber = isEnglishLetter.FirstOrDefault(x => x.Key == number).Value;
            Assert.AreEqual("one billion ", getWordsFromNumber);
        }
    }
}