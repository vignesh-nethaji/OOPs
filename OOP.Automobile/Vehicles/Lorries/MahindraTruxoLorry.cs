using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;

namespace OOP.Automobile.Vehicles.Lorries
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
