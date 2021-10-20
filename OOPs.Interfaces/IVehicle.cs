using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Interfaces
{
    /// <summary>
    ///  interface :: (i) The class which implements the interface,
    ///                   must provide the implementation of all the methods declared inside the interface.
    ///               (ii) used to achive Multiple inheritance.   
    /// </summary>
    public interface IVehicle
    {
        string Name { get; set; }
        int Manufacture { get; set; }
        void Test();
    }
}
