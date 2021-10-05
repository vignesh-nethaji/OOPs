using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.AccessModifier.Base
{
    public class ProtectedInternalDerived : ProtectedInternalBase
    {
        public void Test()
        {
            this.Id = 100;
        }
    }
}
