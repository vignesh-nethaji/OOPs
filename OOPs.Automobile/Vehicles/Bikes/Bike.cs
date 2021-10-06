using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;
using System;

namespace OOPs.Automobile.Vehicles.Bikes
{
    public class Bike : Vehicle, IBike
    {
        private readonly VehicleType _typeOfVehicle = VehicleType.Bike;
        //internal readonly int PSVersion;
        protected Bike(string name, Brand companyName, int cC, bool isGearBike) : base(name, companyName, cC, MachineType.Engine, FuelType.Petrol)
        {
            IsGearBike = isGearBike;
            PSVersion = 4;
        }

        public sealed override VehicleType TypeOfVehicle
        {
            get
            {
                return _typeOfVehicle;
            }
            set
            {
                throw new ArgumentException("Already vehicle type defined as Bike. Don't try to set it");
            }
        }
        public bool IsGearBike { get; }
        internal int PSVersion { get; set; }
    }
}
