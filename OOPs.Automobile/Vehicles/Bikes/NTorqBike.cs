using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;

namespace OOPs.Automobile.Vehicles.Bikes
{
    public sealed class NTorqBike : Bike, IBike
    {
        public NTorqBike() : base(VehicleName.NTorq, Brand.TVS, 125, true)
        {

        }
    }
}
