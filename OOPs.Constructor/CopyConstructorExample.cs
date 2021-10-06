using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Constructor
{

    /// <summary>
    /// One object  assigned the another object constructor input parameter it's called copy constructor.
    /// </summary>
    public class CopyConstructorExample
    {
        #region Copy Constructor
        public CopyConstructorExample(CopyConstructorExample obj)
        {
            this.Name = obj.Name;
            this.Id = obj.Id;
        }
        #endregion

        #region Instance Constructor
        ///Empty constructor
        public CopyConstructorExample()
        {

        }

        /// instance Constructor - Overload passing one input parameter in the constructor.
        public CopyConstructorExample(string name)
        {
            this.Name = name;
        }

        /// instance Constructor - Overload passing two input parameter in the constructor.
        public CopyConstructorExample(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
        #endregion

        /// Id and Name properties.
        public int Id { get; set; }
        public string Name { get; set; }

    }
}

