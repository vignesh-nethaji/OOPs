using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Polymorphism
{
    //Animal is the Base Class
    public class Animal
    {
        //To Override a Method it Should be declared as Virtual Method for Override
        public virtual void Eat()
        {
            Console.WriteLine("General Animal is Eating..");
        }
    }

    //Inherting the Base class to access the Members and Properties of it
    public class Dog : Animal
    {
        //Overriding the eat method from Child class
        public override void Eat()
        {
            Console.WriteLine("Dog is eating bread...");
        }
    }
}
