using OOP.Classes;
using System;

namespace OOPs.Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            //PartialClass partialClass = new PartialClass();
            //partialClass.Address = "xzy";
            //partialClass.Mobile = "123456789";
            //partialClass.Name = "jay";
            // Console.WriteLine(partialClass.Address);

            //User.name = "Suresh Dasari";
            //User.location = "Hyderabad";
            //User.age = 32;
            //Console.WriteLine("Name: {0}", User.name);
            //Console.WriteLine("Location: {0}", User.location);
            //Console.WriteLine("Age: {0}", User.age);
            //User.Details();
            //Console.WriteLine("\nPress Enter Key to Exit..");
            //Console.ReadLine();

            #region Static Class Definition
            User.Details(); // Accessing static class method without creating instance
            User.Age = 12;
            #endregion


            #region Sealed
            SealedClass sealedClass = new SealedClass();
            sealedClass.MyProperty =10;
            #endregion

            #region Partial Definition
            TestPartial testPartial = new TestPartial();
            testPartial.Mobile = "safsdf";
            #endregion
        }
    }
}