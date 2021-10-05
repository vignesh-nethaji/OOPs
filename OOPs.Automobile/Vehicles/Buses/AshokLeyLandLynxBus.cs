using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Automobile.Vehicles.Buses
{

    public sealed class AshokLeyLandLynxBus : Bus, IBus
    {
        public AshokLeyLandLynxBus() : base(VehicleName.Lynx, Brand.AshokLeyLand, 2100, SeaterType.SemiSleeper, 30)
        {

        }
    }
}
