using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;

namespace OOP.Automobile.Vehicles.Cars.Diesels
{
    public class MahindraTharDieselCar : DieselCar, IDieselCar
    {
        public MahindraTharDieselCar() : base(IgnitionQuality.Good, false, VehicleName.Thar, Brand.Mahindra, 1500)
        {
        }
    }
}
