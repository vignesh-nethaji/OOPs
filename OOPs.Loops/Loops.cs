using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Loops
{
    public class Loops
    {

        /// <summary>
        /// Looping in a programming language is a way to execute a statement or a set of statements multiple times depending on the result of the condition to be evaluated to execute statements. 
        /// The result condition should be true to execute statements within loops
        /// </summary>
        public void Forloop()
        {
            //for loop is used to iterate a part of the program several times

            Console.WriteLine("enter number how many times you want to loop :");
            int userinput = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < userinput; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Foreach()
        {
            //The foreach loop is used to iterate over the elements of the collection.
            //The collection may be an array or a list.It executes for each element present in the array

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }

        public void DoWhile()
        {

            // Do While code block will call atleast one time in the execution , after that only it will check the condition

            int i = 10;
            do
            {
                Console.WriteLine("Do While Calling");
                i++;
            } while (i < 10);

        }

        public void While()
        {
            // while loop first check condition before executing code block , if it true then only code block will execute.
            int i = 10;
            while (i < 10)
            {
                Console.WriteLine("While Calling");
                i++;
            }
        }
    }
}
