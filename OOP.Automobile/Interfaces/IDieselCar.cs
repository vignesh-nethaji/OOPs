using OOP.Automobile.Enums;

namespace OOP.Automobile.Interfaces
{
    public interface IDieselCar : IEngineCar
    {
        IgnitionQuality IgnitionType { get; set; }
    }
}
