using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.AccessModifier.Base
{
    public class PrivateProtectedDerived : PrivateProtectedBase
    {
        public void Test()
        {
            // we can access private protected field when we inherit to another class in the same Assembly
            this.Id = 100;
        }
    }
}
