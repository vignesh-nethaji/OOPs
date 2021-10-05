using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;

namespace OOP.Automobile.Vehicles.Cars.Petrols
{
    public class MarutiSwiftPetrolCar : PetrolCar, IPetrolCar
    {
        public MarutiSwiftPetrolCar() : base(false, false, VehicleName.Swift, Brand.Maruti, 1200)
        {

        }
    }
}
