using System;
using System.Collections.Generic;
using System.Text;
using OOPs.AccessModifier.Base;

namespace OOPs.AccessModifier
{
    class PublicDerivedValidate : PublicBase
    {
        public void Test()
        {
            base.Name = "Harish";
        }
    }
}
