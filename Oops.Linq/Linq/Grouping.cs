using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Sln
{
    class Grouping
    {/// <summary>
     /// Projects elements of a collection into groups by key.
     /// This Lambda Expression sample splits array of numbers into two groups: one which is divisible by 10, and one which is not.­

    /// </summary>
        public static void Sample_GroupBy_Lambda()
        {
            int[] numbers = { 10, 15, 20, 25, 30, 35 };

            var result = numbers.GroupBy(n => (n % 10 == 0));

            Console.WriteLine("GroupBy has created two groups:");
            foreach (IGrouping<bool, int> group in result)
            {
                if (group.Key == true)
                    Console.WriteLine("Divisible by 10");
                else
                    Console.WriteLine("Not Divisible by 10");

                foreach (int number in group)
                    Console.WriteLine(number);
            }


        }
    }
}
