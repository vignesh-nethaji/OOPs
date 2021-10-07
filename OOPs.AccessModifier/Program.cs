using System;
using OOPs.AccessModifier.Base;
using OOPs.AccessModifier.MyChange;

namespace OOPs.AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            PublicSampleClass testClass = new PublicSampleClass();
            testClass.NonSecure();
            testClass.Print();

            #region internal validate
            InternalBase internalBase = new InternalBase();
            internalBase.Id = 10;
            #endregion
        }
    }
}
