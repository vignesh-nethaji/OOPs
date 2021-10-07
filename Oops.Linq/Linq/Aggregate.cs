using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Linq_Sln
{
    partial class Program
    {
        class Aggregate
        {/// <summary>
         /// Performs a specified operation to each element in a collection, while carrying the result forward.
         ///This Lambda Expression sample aggregates numbers in array by multiplication
         ///<param name="Argument_1"> Lanbda Expression</param>
         /// </summary>
            public  static void Simple_Aggregate()
            {

                var numbers = new int[] { 1, 2, 3, 4, 5 };

                var result = numbers.Aggregate((a, b) => a * b);

                Console.WriteLine("Aggregated numbers by multiplication:");
                Console.WriteLine(result);
            }
            /// <summary>
            /// Performs a specified operation to each element in a collection, while carrying the result forward. Seed sets initial value.
            /// This Lambda Expression sample aggregates numbers in array by addition, using a seed(seed is an initial value).
            /// <param name="operand1">Seed Value.</param>
            /// <param name="operand2">Expression</param>
            /// </summary>
            public  static void Aggregate_seed()
            {

                var numbers = new int[] { 1, 2, 3 };

                var result = numbers.Aggregate(10, (a, b) => a + b);

                
                Console.WriteLine("Aggregated numbers by addition with a seed of 10:");
                Console.WriteLine(result);
            }


            /// <summary>
            /// Computes the average value for a numeric collections.
            ///This Lambda Expression sample calculates the average of values in array.
            /// </summary>
            public  static void Average() {
                int[] numbers = { 10, 10, 11, 11 };

                var result = numbers.Average();

                Console.WriteLine("Average is:");
                Console.WriteLine(result);
            }

            /// <summary>
            /// Returns the number of elements in a collection.
            /// This Lambda Expression sample counts names in array.
            /// </summary>
            public  static void Count_Lambda()
            {
                string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

                var result = names.Count();

                Console.WriteLine("Counting names gives:");
                Console.WriteLine(result);
            }

            /// <summary>
            /// Returns the number of elements in collections larger than Int32.MaxValue.
            /// This Lambda Expression sample counts elements in array larger than Int32.MaxValue.
            /// <param name="argument_1"></param>
            /// </summary>
            public  static void LongCount_Lambda()
            {
                IEnumerable<int> items = new List<int> { 8, 3, 2 };
                long count = (from x in items where x < 5 select x).LongCount();
                Console.WriteLine(count);
            }
            /// <summary>
            /// Finds the largest value in a collection.
            ///This Lambda Expression sample finds the highest number in array.
            /// </summary>
            public  static void Max() 
            {
                int[] numbers = { 2, 8, 5, 6, 1 };

                var result = numbers.Max();

                Console.WriteLine("Highest number is:");
                Console.WriteLine(result);
            }
            /// <summary>
            /// Finds the smallest value in a collection.
            /// This Lambda Expression sample finds the lowest number in array.
            /// </summary>
            public  static void Min()
            {
                int[] numbers = { 6, 9, 3, 7, 5 };

                var result = numbers.Min();

                Console.WriteLine("Lowest number is:");
                Console.WriteLine(result);
            }
            /// <summary>
            /// Calculates the total for a numeric collections.
            /// This Lambda Expression sample sums three numbers in array.
            /// </summary>
            public  static void Sum_Lambda()
            {
                int[] numbers = { 2, 5, 10 };

                var result = numbers.Sum();

                Console.WriteLine("Summing the numbers yields:");
                Console.WriteLine(result);
            }


        }
    }
}
