using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Cars
{
    public partial class Car : Vehicle, ICar
    {
        private readonly VehicleType _typeofVehicle = VehicleType.Car;
        private readonly int _numberOfWheels = 4;

        public Car()
        {

        }
        public Car(MachineType typeOfMachine)
        {
            this.TypeOfMachine = typeOfMachine;
        }
        public Car(MachineType typeOfMachine, FuelType typeOfFuel) : this(typeOfMachine)
        {
            this.TypeOfFuel = typeOfFuel;
        }

        public Car(string name, Brand companyName, int cC, MachineType typeOfMachine, FuelType typeOfFuel) : base(name, companyName, cC, typeOfMachine, typeOfFuel)
        {

        }
    }


}
