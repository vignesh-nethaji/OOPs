
using System;

namespace OOPs.Operators

{
    class Program
    {
        static void Main(string[] arg)
        {
            AllOperator operation = new AllOperator();
            //Calling the ArithmeticOperator method from the class AllOperator
            operation.ArithmeticOPerator();
            operation.RelationOperator();
            operation.LogicalOperator();
            operation. Precedenceoperator();
            operation.AssignmentOPerator();
        }
    } 
}
