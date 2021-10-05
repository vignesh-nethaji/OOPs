using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;

namespace OOP.Automobile.Vehicles.Cars.Electrics
{
    public class TataTigorEVElectricCar : ElectricCar, IElectricCar
    {
        public TataTigorEVElectricCar() : base(name: VehicleName.Tigor, cC: 1000, companyName: Brand.Tata, isFastCharging: false)
        {
        }
    }
}
