using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;

namespace OOP.Automobile.Vehicles.Cars.Electrics
{
    public class HyundaiKonaElectricCar : ElectricCar, IElectricCar
    {
        public HyundaiKonaElectricCar() : base(name: VehicleName.Kona, cC: 1040, companyName: Brand.Hyundai, isFastCharging: false)
        {
        }
    }
}
