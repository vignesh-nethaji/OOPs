using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Polymorphism
{
    #region Student Example
    /// <summary>
    /// Student Example had == and != operator overloading
    /// </summary>
    public class StudentSample
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public StudentSample()
        {

        }

        public StudentSample(string name)
        {

            this.Name = name;
        }

        public static bool operator ==(StudentSample a, StudentSample b)
        {
            if (a.Id == b.Id && a.Name == b.Name && a.Name != "Vignesh")
            {
                return true;
            }
            else return false;
        }

        public static bool operator !=(StudentSample a, StudentSample b)
        {
            return !(a == b);
        }

        public static implicit operator string(StudentSample a)
        {

            return a.Name;
        }
        public static explicit operator StudentSample(string name)
        {
            return new StudentSample(name);
        }

        //
        // Summary:
        //     Determines whether the specified object is equal to the current object.
        //
        // Parameters:
        //   obj:
        //     The object to compare with the current object.
        //
        // Returns:
        //     true if the specified object is equal to the current object; otherwise, false.
        public override bool Equals(Object? obj)
        {
            return true;
        }
        //
        // Summary:
        //     Serves as the default hash function.
        //
        // Returns:
        //     A hash code for the current object.
        public override int GetHashCode()
        {
            return 1;
        }
    }
    #endregion

    #region Box
    /// <summary>
    /// Box class having + and - operator overloading
    /// </summary>
    public class Box
    {
        private double _length;   // Length of a box
        private double _breadth;  // Breadth of a box
        private double _height;   // Height of a box

        public double GetVolume()
        {
            return _length * _breadth * _height;
        }
        public void SetLength(double length)
        {
            _length = length;
        }
        public void SetBreadth(double breadth)
        {
            _breadth = breadth;
        }
        public void SetHeight(double height)
        {
            _height = height;
        }

        // Overload + operator to add two Box objects.
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box
            {
                _length = b._length + c._length,
                _breadth = b._breadth + c._breadth,
                _height = b._height + c._height
            };
            return box;
        }

        // Overload - operator to add two Box objects.
        public static Box operator -(Box b, Box c)
        {
            Box box = new Box
            {
                _length = b._length - c._length,
                _breadth = b._breadth - c._breadth,
                _height = b._height - c._height
            };
            return box;
        }
    }
    #endregion
}
