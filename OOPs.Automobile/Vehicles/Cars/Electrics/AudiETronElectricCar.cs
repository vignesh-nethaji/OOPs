using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Cars.Electrics
{
    public class AudiETronElectricCar : ElectricCar, IElectricCar
    {
        public AudiETronElectricCar() : base(true, VehicleName.Tron, Brand.Audi, 2000)
        {
        }
    }
}
