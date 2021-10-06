using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Inheritance
{

    /// <summary>
    ///  Multiple Inheritance : one class can have more than one superclass.
    ///  Example :
    ///  A
    ///  B : A
    ///  C : B , A
    ///  D : C , B , A 
    /// </summary>



    #region Interface:
    interface calc1
    {
        int Add(int a, int b);
    }
    interface calc2
    {
        int Sub(int x, int y);
    }
    interface calc3
    {
        int Mul(int r, int s);
    }
    interface calc4
    {
        int Div(int c, int d);
    }

    #endregion


    #region Classes:
    class Calculation : calc1, calc2, calc3, calc4
    {


        public int result1;
        public int Add(int a, int b)
        {
            return result1 = a + b;
        }



        public int result2;
        public int Sub(int x, int y)
        {
            return result2 = x - y;
        }



        public int result3;
        public int Mul(int r, int s)
        {
            return result3 = r * s;
        }



        public int result4;
        public int Div(int c, int d)
        {
            return result4 = c / d;
        }


    }
    #endregion

}
