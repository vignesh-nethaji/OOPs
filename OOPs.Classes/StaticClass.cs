using System;
using System.Collections.Generic;
using System.Text;
namespace OOPs.Classes
{
    /// <summary>
    /// 
    /// </summary>
    static class User
    {
        // Static Variables
        public static string Name;
        public static string Location;
        public static int Age;
        private static string _address;
        /// <summary>
        /// Static method 
        /// </summary>
        public static void Details()
        {
            Console.WriteLine("Static Method");
        }
    }
}