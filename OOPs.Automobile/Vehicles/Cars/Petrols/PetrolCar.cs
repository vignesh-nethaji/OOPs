using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Cars.Petrols
{
    public class PetrolCar : EngineCar, IPetrolCar
    {
        public PetrolCar() : base(FuelType.Petrol)
        {

        }

        public PetrolCar(bool isHigherFuelEfficiency) : base(FuelType.Petrol, isHigherFuelEfficiency)
        {

        }

        public PetrolCar(bool isHigherFuelEfficiency, bool isHighHeatingValue) : this(isHigherFuelEfficiency)
        {
            IsHighHeatingValue = isHighHeatingValue;
        }

        public PetrolCar(bool isHigherFuelEfficiency, string name, Brand companyName, int cC) : base(isHigherFuelEfficiency, name, companyName, cC, FuelType.Petrol)
        {

        }

        public PetrolCar(bool isHighHeatingValue, bool isHigherFuelEfficiency, string name, Brand companyName, int cC) : this(isHigherFuelEfficiency, name, companyName, cC)
        {
            IsHighHeatingValue = isHighHeatingValue;
        }
        public bool IsHighHeatingValue { get; set; }
    }
}
