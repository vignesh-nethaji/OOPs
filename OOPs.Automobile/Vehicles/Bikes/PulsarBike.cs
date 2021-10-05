using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;
using System;

namespace OOPs.Automobile.Vehicles.Bikes
{
    public sealed class PulsarBike : Bike, IBike
    {
        public PulsarBike() : base(VehicleName.Pulsar, Brand.Bajaji, 150, true)
        {
            PSVersion = 6;
            Console.WriteLine($"The PS version of {Name} is {PSVersion}");
        }
    }
}
