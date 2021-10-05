using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;
using System;

namespace OOPs.Automobile.Vehicles.Bikes
{
    public sealed class HornetBike : Bike, IBike
    {
        public HornetBike(string name) : base(name, Brand.Hyundai, 188, true)
        {
            PSVersion = 6;
            Console.WriteLine($"The PS version of {Name} is {PSVersion}");
        }
        public HornetBike() : this(VehicleName.Hornet)
        {

        }

        public static implicit operator string(HornetBike bike)
        {
            return bike.Name;
        }
        public static explicit operator HornetBike(string name)
        {
            return new HornetBike(name);
        }
    }
}
