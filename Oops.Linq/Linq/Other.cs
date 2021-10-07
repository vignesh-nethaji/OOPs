using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Sln
{
    class Other
    {
        /// <summary>
        /// Concatenates (combines) two collections.
        /// This Lambda Expression sample concatenates two arrays of numbers.
        /// </summary>
        public static void Sample_Concat_Lambda_Numbers()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 4, 5, 6 };

            var result = numbers1.Concat(numbers2);

            Console.WriteLine("Concatenating numbers1 and numbers2 gives:");
            foreach (int number in result)
            Console.WriteLine(number);
        }
        /// <summary>
        /// Concatenates (combines) two collections.
        /// This Lambda Expression sample concatenates two arrays of strings.

        /// </summary>
        public static void Sample_Concat_Lambda_Strings()
        {
            string[] vegetables = { "Tomato", "Cucumber", "Carrot" };
            string[] fruits = { "Apples", "Grapes", "Banana" };

            var result = vegetables.Concat(fruits);

            Console.WriteLine("Concatinating vegetables and fruits gives:");
            foreach (string piece in result)
                Console.WriteLine(piece);
        }

        /// <summary>
        /// Checks whether two collections are equal. Use StringComparer.OrdinalIgnoreCase parameter to ignore case.
        /// This Lambda Expression sample shows different methods to test for array equality.
        /// </summary>
        public static void Sample_SequenceEqual_Lambda()
        {
            string[] words = { "one", "two", "three" };
            string[] wordsSame = { "one", "two", "three" };
            string[] wordsOrder = { "two", "three", "one" };
            string[] wordsCase = { "one", "TWO", "three" };

            var resultSame = words.SequenceEqual(wordsSame);
            var resultOrder = words.SequenceEqual(wordsOrder);
            var resultCase = words.SequenceEqual(wordsCase);
            var resultCaseIgnored = words.SequenceEqual(wordsCase, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("SequenceEqual on two identical arrays:");
            Console.WriteLine(resultSame);

            Console.WriteLine("SequenceEqual on two differently ordered but otherwise identical arrays:");
            Console.WriteLine(resultOrder);

            Console.WriteLine("SequenceEqual on two differently cased but otherwise identical arrays:");
            Console.WriteLine(resultCase);

            Console.WriteLine("SequenceEqual on two differently cased but otherwise identical arrays, where case is ignored:");
            Console.WriteLine(resultCaseIgnored);
        }

        /// <summary>
        /// Processes two collections in parallel with func instance, and combines result into a new collection.
        /// This Lambda Expression sample uses Zip to process two arrays in parallel, while each processed pair is summed.
        /// </summary>
        public static void Sample_Zip_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 10, 11, 12 };

            var result = numbers1.Zip(numbers2, (a, b) => (a * b));

            Console.WriteLine("Using Zip to combine two arrays into one (1*10, 2*11, 3*12):");
            foreach (int number in result)
                Console.WriteLine(number);
        }


    }
}
