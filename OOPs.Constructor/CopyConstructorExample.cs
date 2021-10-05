using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Constructor
{
    public class CopyConstructorExample
    {
        /// <summary>
        /// One object  assigned the another object constructor input parameter it's called copy constructor.
        /// </summary>

        #region Copy Constructor

        public CopyConstructorExample(CopyConstructorExample obj)
        {
            this.Name = obj.Name;
            this.Id = obj.Id;
        }
        #endregion

        #region Instance Constructor

        /// <summary>
        ///Empty constructor
        /// </summary>
        
        public CopyConstructorExample()
        {

        }

        /// <summary>
        /// instance Constructor - Overload passing one input parameter in the constructor.
        /// </summary>

        public CopyConstructorExample(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// instance Constructor - Overload passing two input parameter in the constructor.
        /// </summary>
        
        public CopyConstructorExample(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
        #endregion

        /// <summary>
        /// Id and Name properties.
        /// </summary>

        public int Id { get; set; }
        public string Name { get; set; }

    }
}

