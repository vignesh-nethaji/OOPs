using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;

namespace OOP.Automobile.Vehicles.Lorries
{
    public sealed class AshokLeyLandU3718Lorry : Lorry, ILorry
    {
        public AshokLeyLandU3718Lorry() : base(VehicleName.ALU3718, Brand.AshokLeyLand, 1000)
        {
            this.IsSupportsHeavyLoad = false;
            this.NumberOfWheels = 10;
        }
    }
}
