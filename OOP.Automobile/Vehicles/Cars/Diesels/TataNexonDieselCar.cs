using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;

namespace OOP.Automobile.Vehicles.Cars.Diesels
{
    public class TataNexonDieselCar : DieselCar, IDieselCar
    {
        public TataNexonDieselCar() : base(IgnitionQuality.Bad, true, VehicleName.Nexon, Brand.Tata, 900)
        {
        }
    }
}
