using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Constructor
{

    /// <summary>
    /// Same constructor name with different parameter it's called constructor overload.
    /// </summary>

    public class ConstructorOverloadExample : BaseConstructor
    {

        /// <summary>
        /// Empty constructor with BaseConstructor class called using base keyword.
        /// </summary>

        public ConstructorOverloadExample() : base("")
        {

        }

        /// <summary>
        /// constructor overload only one name input parameter called  with BaseConstructor class called using base keyword.
        /// </summary>

        public ConstructorOverloadExample(string name) : base(name)
        {
            //this.Name = name;
        }

        /// <summary>
        /// constructor overload only one id input parameter called  with BaseConstructor class called using base keyword.
        /// </summary>

        public ConstructorOverloadExample(int id) : base("")
        {
           // this.Id = id;
        }

        /// <summary>
        /// constructor overload name and id two input parameter called  with BaseConstructor class called using base keyword.
        /// </summary>

        public ConstructorOverloadExample(int id, string name) : base(name)
        {
            this.Id = id;
            //this.Name = name;
        }

        /// <summary>
        /// constructor overload name and id and mobile three input parameter called  with BaseConstructor class called using base keyword.
        /// </summary>

        public ConstructorOverloadExample(int id, string name, int mobile) : this(id, name)
        {
            //this.Id = id;
            //this.Name = name;
            this.Mobile = mobile;
        }

        /// <summary>
        /// constructor overload name and id and mobile and address four input parameter called  with BaseConstructor class called using base keyword.
        /// </summary>

        public ConstructorOverloadExample(int id, string name, int mobile, string address) : this(id, name, mobile)
        {
            //this.Id = id;
            //this.Name = name;
            //this.Mobile = mobile;
            this.Address = address;
        }


        /// <summary>
        /// Id mobile and address properties.
        /// </summary>

        public readonly int Id;
        public int Mobile { get; set; }
        public string Address { get; set; }

    }

}

