using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Cars.Electrics
{
    public class TataTigorEVElectricCar : ElectricCar, IElectricCar
    {
        public TataTigorEVElectricCar() : base(name: VehicleName.Tigor, cC: 1000, companyName: Brand.Tata, isFastCharging: false)
        {
        }
    }
}
