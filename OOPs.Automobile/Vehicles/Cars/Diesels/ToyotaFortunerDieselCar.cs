using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Cars.Diesels
{
    public class ToyotaFortunerDieselCar : DieselCar, IDieselCar
    {
        public ToyotaFortunerDieselCar() : base(IgnitionQuality.Good, true, VehicleName.Fortuner, Brand.Toyota, 2000)
        {
        }
    }
}
