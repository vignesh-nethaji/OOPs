using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;

namespace OOP.Automobile.Vehicles.Bikes
{
    public sealed class NTorqBike : Bike, IBike
    {
        public NTorqBike() : base(VehicleName.NTorq, Brand.TVS, 125, true)
        {

        }
    }
}
