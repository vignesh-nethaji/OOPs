using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Interfaces
{
    public class Bus : IVehicle
    {
        public string Name { get; set; }
        public int Manufacture { get; set; }
        public string BusProperty { get; set; }

        public void Test()
        {
            //throw new NotImplementedException();
        }
    }
}
