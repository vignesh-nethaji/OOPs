using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Cars.Petrols
{
    public class MarutiSwiftPetrolCar : PetrolCar, IPetrolCar
    {
        public MarutiSwiftPetrolCar() : base(false, false, VehicleName.Swift, Brand.Maruti, 1200)
        {

        }
    }
}
