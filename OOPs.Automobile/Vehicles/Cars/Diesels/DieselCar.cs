using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Cars.Diesels
{
    public class DieselCar : EngineCar, IDieselCar
    {
        public DieselCar() : base(FuelType.Diesel)
        {

        }
        public DieselCar(bool isHigherFuelEfficiency) : base(FuelType.Diesel, isHigherFuelEfficiency)
        {

        }

        public DieselCar(bool isHigherFuelEfficiency, IgnitionQuality ignitionType) : this(isHigherFuelEfficiency)
        {
            IgnitionType = ignitionType;
        }

        public DieselCar(bool isHigherFuelEfficiency, string name, Brand companyName, int cC) : base(isHigherFuelEfficiency, name, companyName, cC, FuelType.Diesel)
        {

        }

        public DieselCar(IgnitionQuality ignitionType, bool isHigherFuelEfficiency, string name, Brand companyName, int cC) : this(isHigherFuelEfficiency, name, companyName, cC)
        {
            IgnitionType = ignitionType;
        }
        public IgnitionQuality IgnitionType { get; set; }
    }
}
