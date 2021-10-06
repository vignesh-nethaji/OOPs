using OOPs.Automobile.Enums;

namespace OOPs.Automobile.Interfaces
{
    public interface IDieselCar : IEngineCar
    {
        IgnitionQuality IgnitionType { get; set; }
    }
}
