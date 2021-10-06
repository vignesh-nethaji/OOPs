using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;
using System;

namespace OOPs.Automobile.Vehicles.Lorries
{
    public class Lorry : Vehicle, ILorry
    {
        private readonly VehicleType _typeofVehicle = VehicleType.Lorry;
        public Lorry()
        {
            TypeOfMachine = MachineType.Engine;
            TypeOfFuel = FuelType.Diesel;
        }

        public Lorry(string name, Brand companyName, int cC) : base(name, companyName, cC, MachineType.Engine, FuelType.Diesel)
        {
        }

        public sealed override VehicleType TypeOfVehicle
        {
            get
            {
                return _typeofVehicle;
            }
            set
            {
                throw new ArgumentException("Already vehicle type defined as Lorry.");
            }
        }

        public bool? IsSupportsHeavyLoad { get; set; }

        public sealed override bool IsValid(string properties = "")
        {
            properties += $"IsSupportsHeavyLoad::{IsSupportsHeavyLoad?.ToString()};";
            bool isValid = base.IsValid(properties);
            //Console.WriteLine("IsSupportsHeavyLoad::" + IsSupportsHeavyLoad);
            if (IsSupportsHeavyLoad == null)
            {
                Console.WriteLine("IsSupportsHeavyLoad is not defined");
                isValid = false;
            }
            return isValid;
        }
    }
}
