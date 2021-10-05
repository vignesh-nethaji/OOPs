using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Cars.Diesels
{
    public class TataNexonDieselCar : DieselCar, IDieselCar
    {
        public TataNexonDieselCar() : base(IgnitionQuality.Bad, true, VehicleName.Nexon, Brand.Tata, 900)
        {
        }
    }
}
