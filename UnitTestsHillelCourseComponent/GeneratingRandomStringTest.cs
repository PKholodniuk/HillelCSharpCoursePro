using NUnit.Framework;
using StringGenerator;
using System.Linq;

namespace UnitTestsHillelCourseComponent
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class GeneratingRandomStringTest
    {
        [TestCase(5, "Hello * World")]
        [TestCase(5, "3fghs5")]
        public void ZeroCheckDictionaryTest(int quantity, string str)
        {
            var generatedString = StringGenerators.GeneratRandomString(quantity, str);

            Assert.AreEqual(quantity, generatedString.Length);
            Assert.IsTrue(str.Contains(generatedString[0]));
            Assert.IsTrue(str.Contains(generatedString[generatedString.Length-1]));
        }
    }
}