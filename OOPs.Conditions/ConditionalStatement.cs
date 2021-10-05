using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Conditions
{
    /// <summary>
    /// 
    /// </summary>
    public class ConditionalStatement
    {
        /// <summary>
        /// Conditional statements help you to make a decision based on certain conditions.
        /// These conditions are specified by a set of conditional statements having boolean expressions which evaluated to a boolean value true or false
        /// </summary>
        public void IfConditional()
        {
            // code block to be executed when if condition evaluates to true
            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else
            {
                Console.WriteLine("x is lessthen y");
            }
        }

        public void ElseIfConditional()
        {

            int i = 10, j = 20;
            if (i == j)
            {
                // code block to be executed when if condition1 evaluates to true
                Console.WriteLine("i is equal to j");
            }
            else if (i > j)
            {
                // code block to be executed when 
                // condition1 evaluates to flase
                // condition2 evaluates to true

                Console.WriteLine("i is greater than j");
            }
            else if (i < j)
            {
                // code block to be executed when 
                // condition1 evaluates to flase
                // condition2 evaluates to false
                // condition3 evaluates to true

                Console.WriteLine("i is less than j");
            }
        }

        public void NestedIfConitional()
        {
            int i = 10, j = 20;

            //first of all check the if condition if you i is not equal to j allow the statement 
            // if you i is equal to j  then go to else statement 

            if (i != j)
            {
                //then check the if condition if you i is less then j allow the statement

                if (i < j)
                {
                    Console.WriteLine("i is less than j");
                }
                else if (i > j)
                {
                    //then check the if condition if you i is greater then j allow the statement

                    Console.WriteLine("i is greater than j");
                }
            }
            else
            {
                Console.WriteLine("i is equal to j");
            }

        }

        public void TernaryOperator()
        {

            //This is ternaryoperator conditional like as if else

            int x = 20, y = 10;

            var result = x > y ? "x is greater than y" : "x is less than y";

            Console.WriteLine(result);
        }

        public void SwitchConditional()
        {

            // Use the switch statement to select one of many code blocks to be executed
            // The switch expression is evaluated once
            //The value of the expression is compared with the values of each case
            //If there is a match, the associated block of code is executed
            //The break and default keywords will be described later in this chapter


            Console.WriteLine("enter the number which day you need? :");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invaild");
                    break;
            }
        }

        public void BreakConditional()
        {

            //The break statement can also be used to jump out of a loop.

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }

        public void ContinueConditional()
        {
            // Here, in this for loop start from 2 to 12, 
            // due to the continue statement, when x = 8
            // it skip the further execution of the statements
            // and transfer the controls back to the 
            // next iteration of the for loop

            for (int x = 2; x <= 12; x++)
            {
                if (x == 8)
                {
                    continue;
                }
                Console.WriteLine(x);
            }
        }
    }
}
