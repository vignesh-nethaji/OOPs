using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Cars
{
    public class EngineCar : Car, IEngineCar
    {
        public EngineCar() : base(MachineType.Engine)
        {
            //TypeOfMachine = MachineType.Engine;
        }

        public EngineCar(FuelType typeOfFuel) : base(MachineType.Engine, typeOfFuel)
        {
            //TypeOfFuel = typeOfFuel;
        }

        public EngineCar(FuelType typeOfFuel, bool isHigherFuelEfficiency) : this(typeOfFuel)
        {
            IsHigherFuelEfficiency = isHigherFuelEfficiency;
        }


        public EngineCar(bool isHigherFuelEfficiency, string name, Brand companyName, int cC, FuelType typeOfFuel) : base(name, companyName, cC, MachineType.Engine, typeOfFuel)
        {
            IsHigherFuelEfficiency = isHigherFuelEfficiency;
        }
        public bool IsHigherFuelEfficiency { get; set; }
    }





}
