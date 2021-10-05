using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;

namespace OOP.Automobile.Vehicles.Cars.Electrics
{
    public class ElectricCar : Car, IElectricCar
    {
        public ElectricCar() : base(MachineType.Motor, FuelType.Electric)
        {
            //TypeOfMachine = MachineType.Motor;
            //TypeOfFuel = FuelType.Electric;
        }
        public ElectricCar(bool isFastCharging, string name, Brand companyName, int cC) : base(name, companyName, cC, MachineType.Motor, FuelType.Electric)
        {
            //TypeOfMachine = MachineType.Motor;
            //TypeOfFuel = FuelType.Electric;
            IsFastCharging = isFastCharging;
            //this.Name = name;
            //CompanyName = companyName;
            //CC = cC;
        }
        public bool IsFastCharging { get; }
    }
}
