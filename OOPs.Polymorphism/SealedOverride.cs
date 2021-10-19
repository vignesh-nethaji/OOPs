using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Polymorphism
{
    public class Flat
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to Beautiful Apartment...");
        }
        public virtual void Display()
        {
            Console.WriteLine("Not ready yet...");
        }
        public virtual void Features()
        {
            Console.WriteLine("Not ready yet...");
            Balcony();
        }
        public virtual void Balcony()
        {
            Console.WriteLine("Not ready yet...");
        }
    }

    public class OneBHK : Flat
    {
        public override void Display()
        {
            Console.WriteLine("This is 1 BHK flat");
        }
        public override void Features()
        {
            Console.WriteLine("\tFeatures...");
            Balcony();
        }
        public override void Balcony()
        {
            Console.WriteLine("\tBalcony: Rectangular\n");
        }

    }


    public class TwoBHK : OneBHK
    {
        public override void Display()
        {
            Console.WriteLine("This is 2 BHK flat");
        }
        public override void Features()
        {
            Console.WriteLine("\tFeatures...");
            Balcony();
        }
        public sealed override void Balcony()
        {
            Console.WriteLine("\tBalcony: Circular\n");
        }
    }

    public  class ThreeBHK : TwoBHK
    {
        public override void Display()
        {
            Console.WriteLine("This is 3 BHK flat");
        }
        public override void Features()
        {
            Console.WriteLine("\tFeatures...");
            Balcony();
        }

        // We cannot override and implement its own balcony type
        // As we have restriction that all flats above TwoBHK will have circular type
        // and cannot desinged their own type.
        // So, it is sealed in TwoBHK class to get cirucular type balcony only.

        //public override void balcony()
        //{
        //    Console.WriteLine("\tBalcony: Circular\n");
        //}
    }
}
