using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Buses
{

    public sealed class BharatBenzBus : Bus, IBus
    {
        public BharatBenzBus() : base(VehicleName.BharatBenz, Brand.Benz, 2700, SeaterType.Sleeper, 35)
        {

        }
    }
}
