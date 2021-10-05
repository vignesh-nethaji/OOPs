using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Lorries
{
    public sealed class MahindraTruxoLorry : Lorry, ILorry
    {
        public MahindraTruxoLorry() : base(VehicleName.Truxo, Brand.Mahindra, 1500)
        {
            IsSupportsHeavyLoad = true;
            NumberOfWheels = 12;
        }
    }
}
