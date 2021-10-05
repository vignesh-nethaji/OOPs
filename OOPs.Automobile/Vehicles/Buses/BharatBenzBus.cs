using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Automobile.Vehicles.Buses
{

    public sealed class BharatBenzBus : Bus, IBus
    {
        public BharatBenzBus() : base(VehicleName.BharatBenz, Brand.Benz, 2700, SeaterType.Sleeper, 35)
        {

        }
    }
}
