using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Cars.Petrols
{
    public class ToyotaFortunerPetrolCar : PetrolCar, IPetrolCar
    {
        public ToyotaFortunerPetrolCar() : base(true, false, VehicleName.Fortuner, Brand.Toyota, 1600)
        {

        }
    }
}
