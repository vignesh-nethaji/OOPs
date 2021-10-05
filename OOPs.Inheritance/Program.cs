using System;


namespace OOPs.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Multilevel Inheritance

            MultiLevel multiLevel = new MultiLevel();
            multiLevel.Test();

            #endregion

            #region Multiple Inheritance


            Calculation c = new Calculation();
            c.Add(8, 2);
            c.Sub(20, 10);
            c.Mul(5, 2);

            Console.WriteLine("Multiple Inheritance concept Using Interfaces : ");
            Console.WriteLine("Addition: " + c.result1);
            Console.WriteLine("Substraction: " + c.result2);
            Console.WriteLine("Multiplication :" + c.result3);
            Console.ReadKey();

            #endregion

        }
    }
}
