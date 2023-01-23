using System;

namespace OOPs.Classes
{
    public abstract class AbstractClass
    {
        public AbstractClass(int i)
        {
            Console.WriteLine("AbstractClass::BaseClass:Constructor::Calling");
            this.Id = i;
        }
        public int Id { get; set; }

        /// <summary>
        /// Protected property or variable can access only from base and derived class.
        /// </summary>
        protected string Name { get; set; }

        /// <summary>
        /// we can't define Abstract method in Abstract class. we can declare it here.
        /// </summary>
        public abstract void AbstractMethod1(); // You can define your own method name. 

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string VirtualMethod1() // You can define your own method name. 
        {
            Console.WriteLine("AbstractClass::VirtualMethod1");
            return "";
        }

        public string Test3() // You can define your own method name. 
        {
            Console.WriteLine("AbstractClass::Test3");
            return "";
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class AbstractDerived1 : AbstractClass
    {
        public AbstractDerived1() : base(8)  // base(8) - Passing constructor parameter for base class.
        {
            base.Name = "AbstractDerived1";
            Console.WriteLine("AbstractDerived1::DerivedClass:Constructor::Calling");
        }

        /// <summary>
        /// Override the Abstract method class which is declared in Abstract.
        /// we should implement the abstract method in derived class .
        /// </summary>
        public override void AbstractMethod1() // You can define your own method name. 
        {
            Console.WriteLine("AbstractDerived1::Override AbstractMethod1");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class AbstractDerived2 : AbstractClass
    {
        public AbstractDerived2() : base(8)  // base(8) - Passing contructor parameter for base class.
        {
            Name = "AbstractDerived2";
            Console.WriteLine("AbstractDerived::DerivedClass:Constructor::Calling");
        }

        /// <summary>
        /// Override the Abstract method class which is declared in Abstract.
        /// we should implement the abstract method in derived class .
        /// </summary>
        public override void AbstractMethod1() // You can define your own method name. 
        { 
            Console.WriteLine("AbstractDerived2::Override AbstractMethod1");
        }

        /// <summary>
        /// Overriding Virtual method is optional.
        /// </summary>
        /// <returns></returns>
        public override string VirtualMethod1()  // You can define your own method name. 
        {
            base.Name = "Protected variable name can change from Derived Class";
            base.VirtualMethod1(); // base keyword is used to access base Class members.
            Console.WriteLine("AbstractDerived2::VirtualMethod1");
            return "";
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class AbstractValidate
    {
        /// <summary>
        /// 
        /// </summary>
        public AbstractValidate()
        {
            CreateAbstractClassInstance();
            CheckAbstractMethod();
            CheckVirtualMethod();
            CheckOverrideVirtualMethod();
            AccessProtectedMember();
        }
        public void CreateAbstractClassInstance() // You can define your own method name. 
        {
            Console.WriteLine("We can't create instance for Abstract class.below line will trigger error at compile time.");
            //AbstractClass abstractClass = new AbstractClass(); // uncomment and check it
        }

        public void CheckAbstractMethod()
        {
            AbstractDerived1 obj = new AbstractDerived1();
            obj.AbstractMethod1();
        }
        public void CheckVirtualMethod()
        {
            AbstractDerived1 obj = new AbstractDerived1();
            obj.VirtualMethod1();
        }

        public void CheckOverrideVirtualMethod()
        {
            AbstractDerived2 obj = new AbstractDerived2();
            obj.VirtualMethod1();
        }

        public void AccessProtectedMember()
        {
            AbstractDerived1 obj = new AbstractDerived1();
           // obj.Name = "New Name"; //Protected members can access only from derived class
        }
    }
}