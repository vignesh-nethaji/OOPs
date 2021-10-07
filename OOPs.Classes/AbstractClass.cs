using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Classes
{
    public abstract class AbstractClass
    {
        public AbstractClass(int i)
        {
            this.MyProperty = i;
        }
        public int MyProperty { get; set; }

        public abstract void Test();


        public virtual string Test2()
        {
            return "";
        }

        public string Test3()
        {
            return "";
        }
    }

    public class AbstractDerived : AbstractClass
    {
        public AbstractDerived() : base(8)
        {

        }
        public override void Test()
        {

        }
    }

    public class AbstractInstance
    {
        public void Test()
        {
            //AbstractClass abstractClass = new AbstractClass(); // uncomment and check it
        }
    }
}