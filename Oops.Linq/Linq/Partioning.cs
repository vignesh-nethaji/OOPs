using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Sln
{
    class Partioning
    {
        /// <summary>
        /// Skips specified number of elements in a collection.
        /// This Lambda Expression sample skips first 4 words in array.
        /// </summary>
        public static void Sample_Skip_Lambda()
        {
            string[] words = { "one", "two", "three", "four", "five", "six" };

            var result = words.Skip(4);

            Console.WriteLine("Skips the first 4 words:");
            foreach (string word in result)
                Console.WriteLine(word);
        }
        /// <summary>
        /// Skips elements in a collection while specified condition is met.
        /// This Lambda Expression sample skips words in array, as long as word has length of 3 characters.

        /// </summary>
        public static void Sample_SkipWhile_Lambda()
        {
            string[] words = { "one", "two", "three", "four", "five", "six" };

            var result = words.SkipWhile(w => w.Length == 3);

            Console.WriteLine("Skips words while the condition is met:");
            foreach (string word in result)
                Console.WriteLine(word);
        }
        /// <summary>
        /// Takes specified number of elements in a collection, starting from first element.
        /// This Lambda Expression sample takes only 5 first numbers in array.
        /// </summary>
        public static void Sample_Take_Lambda()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.Take(5);

            Console.WriteLine("Takes the first 5 numbers only:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        /// <summary>
        /// Takes elements in a collection while specified condition is met, starting from first element.
        /// This Lambda Expression sample takes numbers from array, while number is less than 5.
        /// </summary>
        public static void Sample_TakeWhile_Lambda()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.TakeWhile(n => n < 5);

            Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            foreach (int number in result)
                Console.WriteLine(number);
        }


    }
}
