using System;

namespace OOPs.Polymorphism
{
    public class Program
    {
        public static void Main()
        {
            Validate validate = new Validate();
            int index;
            do
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("Application close : 0");
                Console.WriteLine("Method Overloading : 1");
                Console.WriteLine("Method Override : 2");
                Console.WriteLine("Method Sealed Override : 3");
                Console.WriteLine("Arithmetic Operator Overloading : 4");
                Console.WriteLine("Equality Operator Overloading : 5");
                Console.WriteLine("Conversion Operator Overloading : 6");
                Console.WriteLine("=============================================");

                index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\n");
                switch (index)
                {
                    case 0:
                        Console.WriteLine("Application is closing");
                        break;
                    case 1:
                        validate.MethodOverloading();
                        break;
                    case 2:
                        validate.MethodOverride();
                        break;
                    case 3:
                        validate.MethodSealedOverride();
                        break;
                    case 4:
                        validate.ArithmeticOperatorOverloading();
                        break;
                    case 5:
                        validate.EqualityOperatorOverloading();
                        break;
                    case 6:
                        validate.ConversionOperatorOverloading();
                        break;
                    default:
                        index = 0;
                        break;
                }
                Console.WriteLine("-------------------------------------------------");
            } while (index > 0);
        }
    }
}
