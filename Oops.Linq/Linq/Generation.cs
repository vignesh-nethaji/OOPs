using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Sln
{
    class Generation
    {
        /// <summary>
        /// If a collection is empty, its default value is returned. Default value depends on collection type.
        /// This Lambda Expression sample returns default values for each of the empty collections, while "words" array is returned as is.
        /// </summary>
        public static void Sample_DefaultIfEmpty_Lambda_Simple()
        {
            string[] emptyStr = { };
            int[] emptyInt = { };
            string[] words = { "one", "two", "three" };

            var resultStr = emptyStr.DefaultIfEmpty(); // Default is null for string

            var resultInt = emptyInt.DefaultIfEmpty(); // Default is 0 for int

            var resultWords = words.DefaultIfEmpty(); // Not empty, so words array is just copied

            Console.WriteLine("resultStr has one element with a value of null:");
            Console.WriteLine(resultStr.Count() == 1 && resultStr.First() == null);

            Console.WriteLine("resultInt has one element with a value of 0:");
            Console.WriteLine(resultInt.Count() == 1 && resultInt.First() == 0);

            Console.WriteLine("resultWords has same content as words array:");
            Console.WriteLine(resultWords.SequenceEqual(words));
        }
        /// <summary>
        /// Retruns the default value if the array is empty.
        /// <param name="Argument_1">Default value can be passed as the argument while mehtod Call.</param>
        /// </summary>
        public static void Sample_DefaultIfEmpty_Lambda_DefaultValue()
        {
            int[] empty = { };

            var result = empty.DefaultIfEmpty(5);

            Console.WriteLine("result contains one element with a value of 5:");
            Console.WriteLine(result.Count() == 1 && result.First() == 5);
        }
        /// <summary>
        /// Generates an empty collection (with no elements).
        /// This Lambda Expression sample creates an empty sequence of type string.

        /// </summary>
        public static void Sample_Empty_Lambda()
        {
            var empty = Enumerable.Empty<string>();
            // To make sequence into an array use empty.ToArray()

            Console.WriteLine("Sequence is empty:");
            Console.WriteLine(empty.Count() == 0);
        }
        /// <summary>
        /// Generates sequence of numeric values.
        /// This Lambda Expression sample generates sequence within a range from 0-10.       
        /// </summary>
        public static void Sample_Range_Lambda()
        {
            var result = Enumerable.Range(0, 10);

            Console.WriteLine("Counting from 0 to 9:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
        /// <summary>
        /// Creates a collection of repeated elements, where first argument is value to repeat, and second argument is number of times to repeat.
        /// This Lambda Expression sample repeats the word "Banana" 5 times.

        /// </summary>
        public static void Sample_Repeat_Lambda()
        {
            string word = "Banana";

            var result = Enumerable.Repeat(word, 5);

            Console.WriteLine("String is repeated 5 times:");
            foreach (string str in result)
                Console.WriteLine(str);
        }

    }
}
