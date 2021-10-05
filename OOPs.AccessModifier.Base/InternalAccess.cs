using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.AccessModifier.Base
{
    class InternalAccess
    {
        InternalBase internalBase = new InternalBase();
        public void Test()
        {
            internalBase.FName = "Selva";
        }
    }
}
