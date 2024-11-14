using System;
using System.IO.Compression;
using System.IO;
using System.Text;

namespace Compression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dna = "A" + "C" + "G" + "T";

            var compessedResult = CompressedToBase64(dna);

            Console.WriteLine($"Compression result is: {compessedResult}");

            var uncompressedResult = UncompressedFromBase64(compessedResult);

            Console.WriteLine($"Uncompression result is: {uncompressedResult}");

            Console.ReadLine();
        }

        private static string CompressedToBase64(string data)
        {
            string compessedResult;

            using (MemoryStream input = new MemoryStream(Encoding.GetEncoding("iso-8859-2").GetBytes(data)), outStream = new MemoryStream())
            {
                using (var zipStream = new DeflateStream(outStream, CompressionMode.Compress, true))
                
                input.WriteTo(zipStream);

                var compressedStream = outStream.ToArray();

                compessedResult = Convert.ToBase64String(compressedStream);
            }

            return compessedResult;
        }

        private static string UncompressedFromBase64(string compessedResult)
        {
            var compressedBytes = Convert.FromBase64String(compessedResult);

            using (var inMemStream = new MemoryStream(compressedBytes))
            using (var outMemStream = new DeflateStream(inMemStream, CompressionMode.Decompress))
            using (var streaReader = new StreamReader(outMemStream))

            return streaReader.ReadToEnd();
        }
    }
}
