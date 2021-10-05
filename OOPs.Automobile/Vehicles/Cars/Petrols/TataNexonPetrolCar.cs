using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Cars.Petrols
{
    public class TataNexonPetrolCar : PetrolCar, IPetrolCar
    {
        public TataNexonPetrolCar() : base(true, false, VehicleName.Nexon, Brand.Tata, 1300)
        {

        }
    }
}
