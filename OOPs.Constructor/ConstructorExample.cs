using System;

namespace OOPs.Constructor
{
    public class ConstructorExample
    {
        static void Main(string[] args)
        {
            ///<summary>
            /// copy constructor operation. a object assingned the b object constructor input parameter.
            /// The a object members copy the b object.
            ///</summary>
            CopyConstructorExample student1 = new CopyConstructorExample();
            student1.Id = 19;
            student1.Name = "selva";
            CopyConstructorExample student2 = new CopyConstructorExample(student1);


            ///<summary>
            ///Constructor overload operation.same contrcutor name with different parameters.
            ///</summary>

            ConstructorOverloadExample student = new ConstructorOverloadExample();
            ConstructorOverloadExample studentId = new ConstructorOverloadExample(2);
            ConstructorOverloadExample studentName = new ConstructorOverloadExample("Vignesh");
            ConstructorOverloadExample studentIdAndName = new ConstructorOverloadExample(3, "kumar");
            ConstructorOverloadExample studentIdNameAndNumber = new ConstructorOverloadExample(6, "Arun", 890);
            ConstructorOverloadExample studentIdNameNumberAndAddress = new ConstructorOverloadExample(23, "Ramesh", 457, "Bangalore");
        }
    }
}
