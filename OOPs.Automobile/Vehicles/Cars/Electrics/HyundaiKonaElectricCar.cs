using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Cars.Electrics
{
    public class HyundaiKonaElectricCar : ElectricCar, IElectricCar
    {
        public HyundaiKonaElectricCar() : base(name: VehicleName.Kona, cC: 1040, companyName: Brand.Hyundai, isFastCharging: false)
        {
        }
    }
}
