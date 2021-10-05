using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;

namespace OOP.Automobile.Vehicles.Cars.Petrols
{
    public class HyundaiCretaPetrolCar : PetrolCar, IPetrolCar
    {
        public HyundaiCretaPetrolCar() : base(false, true, VehicleName.Creta, Brand.Hyundai, 950)
        {

        }
    }
}
