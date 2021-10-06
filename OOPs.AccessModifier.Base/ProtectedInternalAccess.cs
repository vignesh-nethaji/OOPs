using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.AccessModifier.Base
{
    public class ProtectedInternalAccess
    {
        public void Test()
        {
            var obj = new ProtectedInternalBase();
            obj.Id = 5;
        }
    }
}
