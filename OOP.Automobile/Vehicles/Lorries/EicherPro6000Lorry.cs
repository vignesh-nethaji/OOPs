using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;

namespace OOP.Automobile.Vehicles.Lorries
{
    public sealed class EicherPro6000Lorry : Lorry, ILorry
    {
        public EicherPro6000Lorry() : base(VehicleName.EicherPro6000, Brand.Tata, 1200)
        {
            this.IsSupportsHeavyLoad = false;
            this.NumberOfWheels = 8;
        }
    }
}
