using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Sln
{
    /// <summary>
    /// Removes duplicate elements from a collection.
    /// This Lambda Expression sample takes only distinct numbers from array.
    /// </summary>
    class Set
    {
        public static void Sample_Distinct_Lambda()
        {
            int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

            var result = numbers.Distinct();

            Console.WriteLine("Distinct removes duplicate elements:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        /// <summary>
        /// Except: Removes all elements from one collection which exist in another collection.
        /// This Lambda Expression sample removes numbers from "numbers1", which exist in "numbers2".
        /// </summary>
        public static void Sample_Except_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Except(numbers2);

            Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
    foreach (int number in result)
                Console.WriteLine(number);
        }
        /// <summary>
        /// Takes only the elements that are shared between two collections.
        /// This Lambda Expression sample creates a new collection with values shared between the two arrays.
        /// </summary>
        public static void Sample_Intersect_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Intersect(numbers2);

            Console.WriteLine("Intersect creates a single sequence with only the duplicates: ");
    foreach (int number in result)
                Console.WriteLine(number);
        }

        /// <summary>
        /// Combines two collections and removes duplicate elements.
        /// This Lambda Expression sample removes any duplicate values between the two arrays.
        /// </summary>
        public static void Sample_Union_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Union(numbers2);

            Console.WriteLine("Union creates a single sequence and eliminates the duplicates: ");
    foreach (int number in result)
                Console.WriteLine(number);
        }


    }
}
