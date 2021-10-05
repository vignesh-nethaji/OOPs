using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Cars.Diesels
{
    public class MahindraTharDieselCar : DieselCar, IDieselCar
    {
        public MahindraTharDieselCar() : base(IgnitionQuality.Good, false, VehicleName.Thar, Brand.Mahindra, 1500)
        {
        }
    }
}
