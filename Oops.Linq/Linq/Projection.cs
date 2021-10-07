using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Sln
{
    /// <summary>
    /// Selects, projects and transforms elements in a collection.
    /// This Lambda Expression sample selects and rounds down each number in array.
    /// </summary>
    class Projection
    {
        public static void Sample_Select_Lambda_Simple()
        {
            decimal[] numbers = { 3.4M, 8.33M, 5.225M };

            var result = numbers.Select(n => Math.Floor(n));

            Console.WriteLine("Numbers rounded down:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

       
        /// <summary>
        /// Selects, projects and transforms elements in a collection. Can be overloaded to get element index.
        /// This Lambda Expression sample selects word and element index from array.
        /// </summary>
        public static void Sample_Select_Lambda_Indexed()
        {
            string[] words = { "one", "two", "three" };

            var result = words.Select((w, i) => new
            {
                Index = i,
                Value = w
            });

            Console.WriteLine("Words with index and value:");
            foreach (var word in result)
                Console.WriteLine(String.Format("Index {0} is {1}", word.Index, word.Value));
        }

        /// <summary>
        /// Flattens collections into a single collection (similar to cross join in SQL).
        /// This Lambda Expression sample cross joins two arrays, and gets cartesian product.
        /// </summary>
        public static void Sample_SelectMany_Lambda()
        {
            string[] fruits = { "Grape", "Orange", "Apple" };
            int[] amounts = { 1, 2, 3 };

            var result = fruits.SelectMany(f => amounts, (f, a) => new
            {
                Fruit = f,
                Amount = a
            });

            Console.WriteLine("Selecting all values from each array, and mixing them:");
            foreach (var o in result)
                Console.WriteLine(o.Fruit + ", " + o.Amount);
        }




    }
}
