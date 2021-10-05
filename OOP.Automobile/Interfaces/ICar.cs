using System;

namespace OOP.Automobile.Interfaces
{
    public interface ICar : IVehicle
    {
        bool IsAcAvailable { get; set; }
        bool IsSunRoofAvailable { get; set; }
        event Action AcStatusChanged;
    }
}
