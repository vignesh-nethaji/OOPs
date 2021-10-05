using System;

namespace OOPs.Automobile.Interfaces
{
    public interface ICar : IVehicle
    {
        bool IsAcAvailable { get; set; }
        bool IsSunRoofAvailable { get; set; }
        event Action AcStatusChanged;
    }
}
