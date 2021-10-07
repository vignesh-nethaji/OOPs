using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.AccessModifier.MyChange
{
    public class PublicSampleClass
    {
        public void NonSecure()
        {
            Console.WriteLine("NonSecure");
        }

        private void Secure()
        {
            Console.WriteLine("Secure");
        }

        public void Print()
        {
            NonSecure();
            Secure();
        }
    }
}
