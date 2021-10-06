using System;
using System.Collections.Generic;
using System.Text;
using OOPs.AccessModifier.Base;

namespace OOPs.AccessModifier
{
    public class PublicValidate 
    {
        PublicBase publicBase = new PublicBase();
        public void Test()
        {
            publicBase.Name = "Kali";
        }
    }
}
