using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Cars.Diesels
{
    public class HyundaiCretaDieselCar : DieselCar, IDieselCar
    {
        public HyundaiCretaDieselCar() : base(IgnitionQuality.Bad, true, VehicleName.Creta, Brand.Hyundai, 800)
        {
        }
    }
}
