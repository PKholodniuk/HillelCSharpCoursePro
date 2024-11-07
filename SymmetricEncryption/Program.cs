using System;
namespace SymmetricEncryption
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var key = "b14ca5898a4e4133bbce2ea2315a1916";

            Console.WriteLine("Please enter a string for encryption");
            var str = Console.ReadLine();

            var encryptedString = AesOperation.EncryptingString(key, str);
            Console.WriteLine($"encrypted string = {encryptedString}");

            var decryptedString = AesOperation.DecryptingString(key, encryptedString);
            Console.WriteLine($"decrypted string = {decryptedString}");

            Console.ReadKey();
        }
    }
}
