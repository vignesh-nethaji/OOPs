using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Constructor
{
    /// <summary>
    /// This is BaseConstructor Class.
    /// </summary>
    public class BaseConstructor
    {
        //This is One Input parameter Constructor.Use class name same as Constructor name.
        public BaseConstructor(string baseName)
        {
            this.Name = baseName;
        }
        //Name data type given Only Read permission
        public readonly string Name;
    }
}
