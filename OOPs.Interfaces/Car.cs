using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Interfaces
{
    public class Car : IVehicle
    {
        private string _carProperty;
        public string Name { get; set; }
        public int Manufacture { get; set; }

        public void Test()
        {

        }
        public string CarProperty
        {
            get
            {
                return _carProperty;
            }
            set
            {
                _carProperty = value;
            }
        }

    }
}
