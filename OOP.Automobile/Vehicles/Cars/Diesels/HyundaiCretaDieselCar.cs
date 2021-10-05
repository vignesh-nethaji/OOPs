using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;

namespace OOP.Automobile.Vehicles.Cars.Diesels
{
    public class HyundaiCretaDieselCar : DieselCar, IDieselCar
    {
        public HyundaiCretaDieselCar() : base(IgnitionQuality.Bad, true, VehicleName.Creta, Brand.Hyundai, 800)
        {
        }
    }
}
