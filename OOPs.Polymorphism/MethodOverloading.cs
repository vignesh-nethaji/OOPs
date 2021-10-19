using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Polymorphism
{
    public class MethodOverloading
    {
        //Two int type Parameters method 
        public int Add(int a, int b)
        {
            //Adding two parameter method
            return a + b;

        }

        //Three int type Parameters with same method same as above
        public int Add(int a, int b, int c)
        {
            //Adding three parameter method
            return a + b + c;

        }

        //Four int type Parameters with same method same as above two method 
        public int Add(int a, int b, int c, int d)
        {
            //Adding four arameter method
            return a + b + c + d;
        }
    }
}
