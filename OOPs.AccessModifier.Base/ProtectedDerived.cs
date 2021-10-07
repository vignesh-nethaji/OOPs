using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.AccessModifier.Base
{
    class ProtectedDerived: ProtectedBase
    {
        public void Test()
        {
            Age = 18;
        }
    }

    class TestProtected
    {
        public void Test()
        {
            ProtectedBase protectedBase = new ProtectedBase();
            //protectedBase.Age = 18; // uncomment and check it.

        }
    }
}
