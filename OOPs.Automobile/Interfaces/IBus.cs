using OOPs.Automobile.Enums;
using OOPs.Automobile.Vehicles.General;

namespace OOPs.Automobile.Interfaces
{
    public interface IBus : IVehicle
    {
        SeaterType TypeOfSeat { get; set; }
        int SeatCount { get; }
        event SeatTypeChangedEventHandler SeatTypeChanged;
    }
}
