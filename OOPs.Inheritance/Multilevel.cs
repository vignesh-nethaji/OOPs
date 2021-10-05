using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Inheritance
{

    /// <summary>
    /// Example:
    /// A 
    /// B : A
    /// C : B
    /// D : C
    /// E : D
    /// </summary>

    public class MultiLevel
    {
        public void Test()
        {

        }

        public class Students
        {
            public int Id { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }

        }

        public class Subject : Students
        {
            public int SubjectId { get; set; }
            public string SubjectName { get; set; }


            //public void StudentDetails()
            //{
            //    Students students = new Students();
            //    students.Id = 101;
            //    students.StudentName = "Learning";
            //    students.Age = 21;
            //}
        }

        public class ClassRoom : Subject
        {
            public int ClassId { get; set; }
            public string ClassName { get; set; }

            //public void SubjectDetails()
            //{
            //    Subject subject = new Subject();
            //    subject.SubjectId = 1001;
            //    subject.SubjectName = "Tamil";
            //}
        }

        public class School : ClassRoom
        {
            public int SchoolId { get; set; }
            public String SchoolName { get; set; }

            //Access the All Classes propertys 

            //public void ClassRoomDetails()
            //{
            //    ClassRoom class1 = new ClassRoom();
            //    class1.ClassId = 10001;
            //    class1.ClassName = "BBS School";
            //}

            //public void SubjectDetails()
            //{
            //    Subject subject = new Subject();
            //    subject.SubjectId = 1001;
            //    subject.SubjectName = "Tamil";
            //}

            //public void StudentDetails()
            //{
            //    Students students = new Students();
            //    students.Id = 101;
            //    students.StudentName = "Learning";
            //    students.Age = 21;
            //}


        }
    }
}
