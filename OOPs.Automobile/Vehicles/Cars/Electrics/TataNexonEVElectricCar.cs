using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Cars.Electrics
{
    public class TataNexonEVElectricCar : ElectricCar, IElectricCar
    {
        public TataNexonEVElectricCar() : base(name: VehicleName.Nexon, cC: 1250, companyName: Brand.Tata, isFastCharging: true)
        {
        }
    }
}
