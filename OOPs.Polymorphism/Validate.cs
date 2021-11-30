using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Polymorphism
{
    public class Validate
    {
        #region Method Overloading
        public void MethodOverloading()
        {
            Console.WriteLine("Method overload calling");
            //Method Overloading
            //Creating a Object for the MethodOverloadin

            MethodOverloading methodOverloading = new MethodOverloading();

            //Calling the add method with parameters
            int a1 = methodOverloading.Add(1, 2);
            int a2 = methodOverloading.Add(1, 2, 3);
            int a3 = methodOverloading.Add(1, 2, 3, 4);
            //In this you can change the parmeters to two or three or four
            //It will automatically call the Overload method for the number of parameters
        }
        #endregion

        #region Method Overriding  
        public void MethodOverride()
        {
            Console.WriteLine("Method override calling");


            Animal animal = new Animal();
            animal.Eat();
            //Creating a Object for the Dog() Class
            Dog d = new Dog();

            //Calling the eat() Method 
            d.Eat();

        }
        #endregion

        #region Method Sealed Override
        public void MethodSealedOverride()
        {
            Console.WriteLine("Method Sealed override calling");
            Flat flat = new Flat();
            flat.Welcome();
            flat.Display();
            flat.Features();
            flat.Balcony();

            OneBHK oneBHK = new OneBHK();
            oneBHK.Welcome();
            oneBHK.Display();
            oneBHK.Features();
            oneBHK.Balcony();

            TwoBHK twoBHK = new TwoBHK();
            twoBHK.Welcome();
            twoBHK.Display();
            twoBHK.Features();
            twoBHK.Balcony();

            ThreeBHK threeBHK = new ThreeBHK();
            threeBHK.Welcome();
            threeBHK.Display();
            threeBHK.Features();
            threeBHK.Balcony();

        }
        #endregion

        #region Operator Overloading (+ and -)
        public void ArithmeticOperatorOverloading()
        {
            Console.WriteLine("Arithmetic Operator Overloading calling");


            //Operator Overloading
            Box box1 = new Box();   // Declare Box1 of type Box
            Box box2 = new Box();   // Declare Box2 of type Box

            // box 1 specification
            box1.SetLength(6.0);
            box1.SetBreadth(7.0);
            box1.SetHeight(5.0);

            // box 2 specification
            box2.SetLength(12.0);
            box2.SetBreadth(13.0);
            box2.SetHeight(10.0);

            // volume of box 1
            double volume = box1.GetVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            // volume of box 2
            volume = box2.GetVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);

            // Add two object as follows:
            Box box3 = box1 + box2;

            // volume of box 3
            volume = box3.GetVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);

        }
        #endregion

        #region Operator Overloading (== and !=)
        public void EqualityOperatorOverloading()
        {

            Console.WriteLine("Equality Operator Overloading calling");

            StudentSample s1 = new StudentSample
            {
                Id = 10,
                Name = "Vignesh"
            };

            StudentSample s2 = new StudentSample
            {
                Id = 10,
                Name = "Vignesh"
            };

            if (s1.Id == s2.Id && s1.Name == s2.Name)
            {
                Console.WriteLine("Without operator overloading Condition true");
            }
            else
            {
                Console.WriteLine("Without operator overloading Condition false");
            }

            if (s1 == s2)
            {
                Console.WriteLine("With operator overloading Condition true");
            }
            else
            {
                Console.WriteLine("With operator overloading Condition false");
            }

            if (s1 != s2)
            {
                Console.WriteLine("With operator overloading Condition true");
            }
            else
            {
                Console.WriteLine("With operator overloading Condition false");
            }

        }
        #endregion

        #region Conversion Overloading
        public void ConversionOperatorOverloading()
        {
            Console.WriteLine("Conversion Operator Overloading calling");

            int i = 10;
            long l = i; // implicit 
            long k = 100;
            int j = (int)k; // Expicit

            StudentSample s3 = new StudentSample
            {
                Name = "kumar"
            };

            string name = s3; // implicit
            string strName = "Vignesh";
            StudentSample s5 = (StudentSample)strName; // Explicit conversion 
        }
        #endregion
    }
}
