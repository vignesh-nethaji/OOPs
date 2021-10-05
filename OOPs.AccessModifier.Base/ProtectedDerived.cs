using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.AccessModifier.Base
{
    class ProtectedDerived:ProtectedBase
    {
        public void Test()
        {
            base.Age = 18;
        }
    }
}
