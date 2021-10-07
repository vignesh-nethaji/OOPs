using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Sln
{
    class Quantifiers
    {/// <summary>
     /// Checks if all elements in a collection satisfies a specified condition.
     /// This Lambda Expression sample checks whether all names in array start with letter "B".
     /// </summary>
        public static void Sample_All_Lambda()
        {
            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.All(n => n.StartsWith("B"));

            Console.WriteLine("Does all of the names start with the letter 'B':");
            Console.WriteLine(result);
        }
        /// <summary>
        /// Checks if any elements in a collection satisifies a specified condition.
        /// This Lambda Expression sample checks whether any names in array start with the letter 'B'.
        /// </summary>
        public static void Sample_Any_Lambda()
        {
            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.Any(n => n.StartsWith("B"));

            Console.WriteLine("Does any of the names start with the letter 'B':");
            Console.WriteLine(result);
        }

        /// <summary>
        /// Checks if any elements in a collection satisifies a specified value.
        /// This Lambda Expression sample checks whether array of numbers contains value of 5.
        /// </summary>
        public static void Sample_Contains_Lambda()
        {
            int[] numbers = { 1, 3, 5, 7, 9 };

            var result = numbers.Contains(5);

            Console.WriteLine("sequence contains the value 5:");
            Console.WriteLine(result);
        }

    }
}
