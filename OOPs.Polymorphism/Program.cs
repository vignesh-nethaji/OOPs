
using System;

namespace OOPs.Polymorphism
{
    #region Method Override
    //Animal is the Base Class
    public class Animal
    {
        //To Override a Method it Should be declared as Virtual Method for Override

        public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    //Inherting the Base class to access the Members and Properties of it

    public class Dog : Animal
    {
        //Overriding the eat method from Child class
        public override void eat()
        {
            Console.WriteLine("Eating bread...");
        }
    }
    #endregion

    #region Method Overloading
    //Method Overloading

    public class MethodOverloading
    {
        //Two int type Parameters method 
        public int add(int a, int b)
        {
            //Adding two parameter method
            return a + b;

        }

        //Three int type Parameters with same method same as above
        public int add(int a, int b, int c)
        {
            //Adding three parameter method
            return a + b + c;

        }

        //Four int type Parameters with same method same as above two method 
        public float add(int a, int b, int c, int d)
        {
            //Adding four arameter method
            return a + b + c + d;

        }
    }
    #endregion

    #region Operator Overloading
    //Operator Overloading

    class Box
    {
        private double length;   // Length of a box
        private double breadth;  // Breadth of a box
        private double height;   // Height of a box

        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }

        // Overload + operator to add two Box objects.
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }
    }
    #endregion

    #region Implicit Operator Overload
    //Implicit Operator Overload
    #endregion

    #region Explicit Operator Overload
    //Explicit Operator Overload
    #endregion

    #region Main Method
    public class MainMethod
    {
        //Intializing the Main Method

        public static void Main()
        {
            //Method Overriding
            //Creating a Object for the Dog() Class

            Dog d = new Dog();

            //Calling the eat() Method 
            d.eat();

            //Method Overloading
            //Creating a Object for the MethodOverloadin

            MethodOverloading md = new MethodOverloading();

            //Calling the add method with parameters
            md.add(1, 2, 3, 4);
            //In this you can change the parmeters to two or three or four
            //It will automatically call the Overload method for the number of parameters

            //Operator Overloading
            Box Box1 = new Box();   // Declare Box1 of type Box
            Box Box2 = new Box();   // Declare Box2 of type Box
            Box Box3 = new Box();   // Declare Box3 of type Box
            double volume = 0.0;    // Store the volume of a box here

            // box 1 specification
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            // box 2 specification
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);

            // volume of box 1
            volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            // volume of box 2
            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);

            // Add two object as follows:
            Box3 = Box1 + Box2;

            // volume of box 3
            volume = Box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);
            Console.ReadKey();

        }
    }
    #endregion
}
