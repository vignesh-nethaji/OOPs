using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Linq_Sln
{
    public class Conversion
    {
        /// <summary>
        /// Properties required for Dictionary_Method
        /// </summary>
        public string EnglishSalute { get; internal set; }
        public string GermanSalute { get; internal set; }

        /// <summary>
        /// Casts a collection to IEnumerable of same type.
        ///This Lambda Expression sample casts array of strings to its corresponding IEnumerable.
        /// </summary>


        public static void Sample_AsEnumerable_Lambda()
        {
            string[] names = { "John", "Suzy", "Dave" };

            var result = names.AsEnumerable();

            Console.WriteLine("Iterating over IEnumerable collection:");
            foreach (var name in result)
                Console.WriteLine(name);
        }
        /// <summary>
        /// Casts a collection to a specified type.
        /// This Lambda Expression sample casts list of strings to a simple string array.
        /// </summary>
        public static void Sample_Cast_Lambda()
        {
            List<string> vegetables = new List<string> { "Cucumber", "Tomato", "Broccoli" };

            var result = vegetables.Cast<string>();

            Console.WriteLine("List of vegetables casted to a simple string array:");
            foreach (string vegetable in result)
                Console.WriteLine(vegetable);
        }

        /// <summary>
        /// Filters elements of specified type in a collection.
        /// This Lambda Expression sample takes only objects of type string.
        /// </summary>
        public static void Sample_OfType_Lambda()
        {
            object[] objects = { "Thomas", 31, 5.02, null, "Joey" };

            var result = objects.OfType<string>();

            Console.WriteLine("Objects being of type string have the values:");
            foreach (string str in result)
                Console.WriteLine(str);
        }

        /// <summary>
        /// Converts type to a new array.
        /// This Lambda Expression sample converts one array to another.
        /// </summary>
        public static void Sample_ToArray_Lambda()
        {
            int[] numbers = { 1, 2, 3, 4 };

            var result = numbers.ToArray();

            Console.WriteLine("New array contains identical values:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        /// <summary>
        /// Converts collection into a Dictionary with Key and Value.
        ///This Lambda Expression sample inserts custom values into a dictionary.
        /// </summary>
        public static void Sample_ToDictionary_Lambda_Simple()
        {
            Conversion[] english2German =
            {
        new Conversion { EnglishSalute = "Good morning",
                             GermanSalute = "Guten Morgen" },
        new Conversion { EnglishSalute = "Good day",
                             GermanSalute = "Guten Tag" },
        new Conversion { EnglishSalute = "Good evening",
                             GermanSalute = "Guten Abend" },
    };

            var result = english2German.ToDictionary(k => k.EnglishSalute,
        v => v.GermanSalute);

            Console.WriteLine("Values inserted into dictionary:");
            foreach (KeyValuePair<string, string> dic in result)
            {
                Console.WriteLine(String.Format("English salute {0} is {1} in German",
              dic.Key, dic.Value));
            }
        }

        /// <summary>
        /// Converts collection into a Dictionary with Key and Value.
        /// This Lambda Expression sample uses ToDictionary to make a new array based on condition.
        /// </summary>
        public static void Sample_ToDictionary_Lambda_Conditional()
        {
            int[] numbers = { 1, 2, 3, 4 };

            var result = numbers.ToDictionary(k => k, v => (v % 2) == 1 ? "Odd" : "Even");

            Console.WriteLine("Numbers labeled Odd and Even in dictionary:");
            foreach (var dic in result)
                Console.WriteLine("Value {0} is {1}", dic.Key, dic.Value);
        }

        /// <summary>
        /// Converts collection into a List.
        /// This Lambda Expression sample converts string array to List of strings.
        /// </summary>
        public static void Sample_ToList_Lambda()
        {
            string[] names = { "Brenda", "Carl", "Finn" };

            List<string> result = names.ToList();

            Console.WriteLine(String.Format("names is of type: {0}",names.GetType().Name));
            Console.WriteLine(String.Format("result is of type: {0}",result.GetType().Name));
        }

        /// <summary>
        /// Converts a collection into a Lookup, grouped by key.
        /// This Lambda Expression sample puts array elements into a one-to-many Lookup, where key equals element length.
        /// </summary>
        public static void Sample_ToLookup_Lambda()
        {
            string[] words = {"one", "two", "three", "four", "five", "six", "seven" };

            var result = words.ToLookup(w => w.Length);

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(String.Format("Elements with a length of {0}:",
         i));
                foreach (string word in result[i])
                    Console.WriteLine(word);
            }
        }


    }
}