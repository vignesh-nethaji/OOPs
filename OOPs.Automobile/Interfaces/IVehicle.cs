using OOPs.Automobile.Enums;

namespace OOPs.Automobile.Interfaces
{
    /// <summary>
    /// IVehicle is the base declaration for all the vehicles. 
    /// It has common properties declaration's for any vehicle
    /// Interface is the blueprint of the definition class
    /// we should define the interface properties and methods in derived class 
    /// All the interface name prefix should come as "I".
    /// </summary>
    public interface IVehicle
    {
        VehicleType TypeOfVehicle { get; set; }
        MachineType TypeOfMachine { get; set; }
        FuelType TypeOfFuel { get; set; }
        string Name { get; set; }
        string ChaseNumber { get; set; }
        int ManufactureYear { get; set; }
        System.Drawing.Color Color { get; set; }
        int NumberOfWheels { get; set; }
        Brand CompanyName { get; set; }
        bool IsValid(string properties = "");
    }
}
