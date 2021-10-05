using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.AccessModifier.Base
{
    public class PrivateProtectedAccess
    {
        public void Test()
        {
            var obj = new PrivateProtectedBase();
            // We can't access private protected field using instance of class even its same assembly
            // obj.Id = 5;
        }
    }
}
