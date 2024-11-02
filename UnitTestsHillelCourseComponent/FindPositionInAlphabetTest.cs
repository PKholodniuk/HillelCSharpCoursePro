using NUnit.Framework;

namespace UnitTestsHillelCourseComponent
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class FindPositionInAlphabetTest
    {
        [TestCase('a')]
        [TestCase('z')]
        [TestCase('C')]
        public void CheckExtensionMethodIsEnglishLetterTest(char letter)
        {
            bool isEnglishLetter = FindPositionInAlphabet.ExtensionChar.IsEnglishLetter(letter);
            Assert.IsTrue(isEnglishLetter);
        }

        [TestCase('1')]
        [TestCase('*')]
        [TestCase('/')]
        [TestCase('¿')]
        [TestCase('#')]
        public void IsNotEnglishLetterTest(char letter)
        {
            bool isEnglishLetter = FindPositionInAlphabet.ExtensionChar.IsEnglishLetter(letter);
            Assert.IsFalse(isEnglishLetter);
        }

        [TestCase('a')]
        [TestCase('A')]
        public void LetterA_ReturnPositionInEnglishAlphabetTest(char letter)
        {
            var isEnglishLetter = FindPositionInAlphabet.ExtensionChar.ReturnPositionInEnglishAlphabet(letter);
            Assert.AreEqual(1, isEnglishLetter);
            Assert.AreNotEqual(10, isEnglishLetter);
        }

        [TestCase('z')]
        [TestCase('Z')]
        public void LetterZ_ReturnPositionInEnglishAlphabetTest(char letter)
        {
            var isEnglishLetter = FindPositionInAlphabet.ExtensionChar.ReturnPositionInEnglishAlphabet(letter);
            Assert.AreEqual(26, isEnglishLetter);
            Assert.AreNotEqual(25, isEnglishLetter);
        }

        [TestCase('j')]
        [TestCase('J')]
        public void LetterJ_ReturnPositionInEnglishAlphabetTest(char letter)
        {
            var isEnglishLetter = FindPositionInAlphabet.ExtensionChar.ReturnPositionInEnglishAlphabet(letter);
            Assert.AreEqual(10, isEnglishLetter);
            Assert.AreNotEqual(1, isEnglishLetter);
        }
    }
}