using OOPs.Automobile.Enums;
using System;

namespace OOPs.Automobile.Vehicles.General
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
