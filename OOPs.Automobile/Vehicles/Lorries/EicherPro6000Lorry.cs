using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Lorries
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
