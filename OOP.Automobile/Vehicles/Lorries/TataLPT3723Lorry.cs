﻿using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;

namespace OOP.Automobile.Vehicles.Lorries
{
    public sealed class TataLPT3723Lorry : Lorry, ILorry
    {
        public TataLPT3723Lorry() : base(VehicleName.TataLPT3723, Brand.Tata, 1600)
        {
            this.IsSupportsHeavyLoad = true;
            this.NumberOfWheels = 16;
        }
    }
}
