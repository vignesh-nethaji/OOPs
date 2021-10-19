using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Operators
{
    class AllOperator
    {
        public void ArithmeticOPerator()
        {
            int result;
            int x = 20, y = 10;
            result = (x + y);
            Console.WriteLine("Addition Operator: " + result);
            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);
            result = (x * y);
            Console.WriteLine("Multiplication Operator: " + result);
            result = (x / y);
            Console.WriteLine("Division Operator: " + result);
            result = (x % y);
            Console.WriteLine("Modulo Operator: " + result);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }

        public void RelationOperator()
        {
            bool result;
            int x = 10, y = 20;
            result = (x == y);
            Console.WriteLine("Equal to Operator: " + result);
            result = (x > y);
            Console.WriteLine("Greater than Operator: " + result);
            result = (x <= y);
            Console.WriteLine("Lesser than or Equal to: " + result);
            result = (x != y);
            Console.WriteLine("Not Equal to Operator: " + result);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }

        public void LogicalOperator()
        {
            int x = 15, y = 10;
            bool a = true, result;
            // AND operator
            result = (x <= y) && (x > 10);
            Console.WriteLine("AND Operator: " + result);
            // OR operator
            result = (x >= y) || (x < 5);
            Console.WriteLine("OR Operator: " + result);
            //NOT operator
            result = !a;
            Console.WriteLine("NOT Operator: " + result);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }

        public void Precedenceoperator()
        {
            int x = 20, y = 5, z = 4;
            int result = x / y + z;
            Console.WriteLine("Result1: " + result);
            bool result2 = z <= y + x;
            Console.WriteLine("Result2: " + result2);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }

        public void AssignmentOPerator()
        {
            int x = 20;
            x += 10;
            Console.WriteLine("Add Assignment: " + x);
            x *= 4;
            Console.WriteLine("Multiply Assignment: " + x);
            x %= 7;
            Console.WriteLine("Modulo Assignment: " + x);
            x &= 10;
            Console.WriteLine("Bitwise And Assignment: " + x);
            x ^= 12;
            Console.WriteLine("Bitwise XOR Assignment: " + x);
            x >>= 3;
            Console.WriteLine("Right Shift Assignment: " + x);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
