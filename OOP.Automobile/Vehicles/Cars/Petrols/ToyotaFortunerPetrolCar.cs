using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;

namespace OOP.Automobile.Vehicles.Cars.Petrols
{
    public class ToyotaFortunerPetrolCar : PetrolCar, IPetrolCar
    {
        public ToyotaFortunerPetrolCar() : base(true, false, VehicleName.Fortuner, Brand.Toyota, 1600)
        {

        }
    }
}
