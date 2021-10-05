using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;

namespace OOP.Automobile.Vehicles.Cars.Petrols
{
    public class TataNexonPetrolCar : PetrolCar, IPetrolCar
    {
        public TataNexonPetrolCar() : base(true, false, VehicleName.Nexon, Brand.Tata, 1300)
        {

        }
    }
}
