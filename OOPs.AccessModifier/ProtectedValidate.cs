using System;
using System.Collections.Generic;
using System.Text;
using OOPs.AccessModifier.Base;

namespace OOPs.AccessModifier
{
    public class ProtectedValidate : ProtectedBase
    {
        public void Test()
        {
            base.Age = 20;
        }
    }
}
