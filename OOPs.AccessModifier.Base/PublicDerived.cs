using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.AccessModifier.Base
{
    class PublicDerived : PublicBase
    {
        public void Test()
        {
            this.Name = "Karthi";
        }
    }
}
