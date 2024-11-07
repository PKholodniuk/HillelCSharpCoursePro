using NUnit.Framework;
using SymmetricEncryption;

namespace UnitTestsHillelCourseComponent
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class EncryptionAndDecryptionTest
    {
        [TestCase("Hello World")]
        [TestCase("3fghs5")]
        public void ZeroCheckDictionaryTest(string value)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            var encryptedString = AesOperation.EncryptingString(key, value);

            Assert.AreNotEqual(value, encryptedString);

            var decryptedString = AesOperation.DecryptingString(key, encryptedString);

            Assert.AreEqual(value, decryptedString);
        }
    }
}