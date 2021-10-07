using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.AccessModifier.Base
{
    class InternalAccess
    {
       
        public void Test()
        {
            InternalBase internalBase = new InternalBase();
            internalBase.FName = "Selva";
            internalBase.Id = 10 ;
        }
    }
}
