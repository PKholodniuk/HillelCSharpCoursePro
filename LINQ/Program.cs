using System;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Tasks 1 & 2

            var query = Enumerable.Range(1, 60);

            Console.WriteLine($"Result of Task 1: {string.Join(" ", query.Where(number => number >= 10 & number <= 50)) }");

            Console.WriteLine($"Result of Task 2: {string.Join(" ", query.Where(number => number >= 10 & number <= 50 & number % 3 == 0)) }");

            #endregion

            #region Task 3

            Enumerable.Range(1, 10).ToList().ForEach(_ => Console.WriteLine("Linq"));

            #endregion

            #region Task 4 & 5

            var task4 = "aaa;abb;ccc;dap";

            Console.WriteLine($"Result of Task 4. The words contain 'a': {string.Join(" ", task4.Split(';').Where(word => word.ToString().Contains('a')))}" );

            Console.WriteLine($"Result of Task 5. Count 'a' in each present 'a' words: {string.Join(", ", task4.Split(';').Where(word => word.ToString().Contains('a')).ToList().Select(word => word.Count(c => c == 'a')))}");

            #endregion


            #region Tasks 6 & 7 & 8

            string input = "aaa;xabbx;abb;ccc;dap";

            Console.WriteLine($"Result of Task 6. The word \"abb\" is present: {input.Split(';').Any(word => word == "abb")}");

            Console.WriteLine($"Result of Task 7. The longest word is: {input.Split(';').Where(word => word.Count() == input.Split(';').Max(w => w.Count())).FirstOrDefault()}");

            Console.WriteLine($"Result of Task 8. The average length is: {input.Split(';').Average(word => word.Count())}");

            #endregion

            #region Task 9

            var task9 = "aaa;xabbx;abb;ccc;dap;zh";

            Console.WriteLine($"Result of Task 9. Reverse the shortest word: " +
                $"{string.Join("", task9.Split(';').Where(word => word.Count() == task9.Split(';').Min(w => w.Count())).Select(w => w.Reverse()).FirstOrDefault())}");

            #endregion


            #region Tasks 10 & 11

            var task10And11 = "baaa;aabb;aaa;xabbx;abb;ccc;dap;zh";

            Console.WriteLine($"Result of Task 10. All letters equal 'b' in the words that starts with \"aa\": " +
                $"{task10And11.Split(';').Where(word => word.StartsWith("aa")).FirstOrDefault().Skip(2).All(letters => letters == 'b')}");


            Console.WriteLine($"Result of Task 11. Tte latest word that ends on 'bb' and skip 2 of them: " 
                + $" {task10And11.Split(';').Where(word => word.EndsWith("bb")).ToList().Skip(2).FirstOrDefault()}");

            #endregion

            Console.ReadLine();

        }
    }
}
