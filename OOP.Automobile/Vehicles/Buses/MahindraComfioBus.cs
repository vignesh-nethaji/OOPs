using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Buses
{

    public sealed class MahindraComfioBus : Bus, IBus
    {
        public MahindraComfioBus() : base(VehicleName.Comfio, Brand.Mahindra, 1900, SeaterType.NormalSeating, 30)
        {

        }
    }
}
