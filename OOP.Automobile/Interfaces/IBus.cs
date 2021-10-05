using OOP.Automobile.Enums;
using OOP.Automobile.Vehicles.General;

namespace OOP.Automobile.Interfaces
{
    public interface IBus : IVehicle
    {
        SeaterType TypeOfSeat { get; set; }
        int SeatCount { get; }
        event SeatTypeChangedEventHandler SeatTypeChanged;
    }
}
