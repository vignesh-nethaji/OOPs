using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Classes
{
    public sealed class SealedClass
    {
        public int MyProperty { get; set; }

    }

    public class SealedTest
    {
        public void Test()
        {
            SealedClass sealedClass = new SealedClass();
        }
    }
}
