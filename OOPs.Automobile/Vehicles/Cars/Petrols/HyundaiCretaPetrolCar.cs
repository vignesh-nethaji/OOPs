using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Cars.Petrols
{
    public class HyundaiCretaPetrolCar : PetrolCar, IPetrolCar
    {
        public HyundaiCretaPetrolCar() : base(false, true, VehicleName.Creta, Brand.Hyundai, 950)
        {

        }
    }
}
