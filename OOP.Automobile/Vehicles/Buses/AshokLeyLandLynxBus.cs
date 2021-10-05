using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Buses
{

    public sealed class AshokLeyLandLynxBus : Bus, IBus
    {
        public AshokLeyLandLynxBus() : base(VehicleName.Lynx, Brand.AshokLeyLand, 2100, SeaterType.SemiSleeper, 30)
        {

        }
    }
}
