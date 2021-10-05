using OOP.Automobile.Enums;
using System;

namespace OOP.Automobile.Vehicles.General
{
    public class SeatTypeChangedEventArgs : EventArgs
    {
        public SeatTypeChangedEventArgs(SeaterType oldSeatType, SeaterType newSeatType)
        {
            OldSeatType = oldSeatType;
            NewSeatType = newSeatType;
        }
        public SeaterType OldSeatType { get; }
        public SeaterType NewSeatType { get; }
    }
}
