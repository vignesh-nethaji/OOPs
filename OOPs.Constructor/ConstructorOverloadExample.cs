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
        /// Empty constructor with BaseConstructor class called using base keyword.
        public ConstructorOverloadExample() : base("")
        {

        }

        /// constructor overload only one name input parameter called  with BaseConstructor class called using base keyword.
        public ConstructorOverloadExample(string name) : base(name)
        {
            //this.Name = name;
        }

        /// constructor overload only one id input parameter called  with BaseConstructor class called using base keyword.
        public ConstructorOverloadExample(int id) : base("")
        {
            // this.Id = id;
        }

        /// constructor overload name and id two input parameter called  with BaseConstructor class called using base keyword.
        public ConstructorOverloadExample(int id, string name) : base(name)
        {
            this.Id = id;
            //this.Name = name;
        }

        /// constructor overload name and id and mobile three input parameter called  with BaseConstructor class called using base keyword.
        public ConstructorOverloadExample(int id, string name, int mobile) : this(id, name)
        {
            //this.Id = id;
            //this.Name = name;
            this.Mobile = mobile;
        }

        /// constructor overload name and id and mobile and address four input parameter called  with BaseConstructor class called using base keyword.
        public ConstructorOverloadExample(int id, string name, int mobile, string address) : this(id, name, mobile)
        {
            //this.Id = id;
            //this.Name = name;
            //this.Mobile = mobile;
            this.Address = address;
        }

        /// Id mobile and address properties.
        public readonly int Id;
        public int Mobile { get; set; }
        public string Address { get; set; }

    }

}

