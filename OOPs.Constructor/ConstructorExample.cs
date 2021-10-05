using System;

namespace OOPs.Constructor
{
    /// <summary>
    /// This is main program class.
    /// </summary>
    public class ConstructorExample
    {
        static void Main(string[] args)
        {
            ///This is copy constructor operation.
            ///student1 object assingned the student2 object constructor input parameter.
            ///The student1 object members copy the student2 object.
            ///</summary>
            CopyConstructorExample student1 = new CopyConstructorExample();
            student1.Id = 19;
            student1.Name = "selva";
            CopyConstructorExample student2 = new CopyConstructorExample(student1);

            ///<summary>
            ///This is Constructor overload operation.
            ///same contrcutor name with different input parameters.
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
