using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.AccessModifier.Base
{
    class PublicAccess
    {
        public void Test()
        {
            PublicBase publicBase = new PublicBase();
            publicBase.Name = "Hello";
        }
    }
}
