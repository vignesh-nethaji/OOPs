using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;

namespace OOP.Automobile.Vehicles.Cars.Electrics
{
    public class AudiETronElectricCar : ElectricCar, IElectricCar
    {
        public AudiETronElectricCar() : base(true, VehicleName.Tron, Brand.Audi, 2000)
        {
        }
    }
}
