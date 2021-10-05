using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;

namespace OOP.Automobile.Vehicles.Bikes
{
    public sealed class ActivaBike : Bike, IBike
    {
        public ActivaBike() : base(VehicleName.Activa, Brand.Honda, 125, true)
        {
            Console.WriteLine(VehicleName.Activa + " bike is created...");
        }
    }
}
