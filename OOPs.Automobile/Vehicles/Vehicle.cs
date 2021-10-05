using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;
using System;
using System.Drawing;

namespace OOPs.Automobile.Vehicles
{
    /// <summary>
    /// Vehicle is the base class for all vehicle
    /// It has common properties of all vehicles
    /// WE can't create instance for abstract class, so it has support only inherit to other class
    /// </summary>
    public abstract class Vehicle : IVehicle
    {
        // Region is used to grouping the Fields or methods or else other's
        #region Private Declaration and Definitions
        /// <summary>
        /// Static property or variable will create memory on application runtime
        /// This memory will clear only on application stop.
        /// Readonly property or variable or methods can set the value only on Contructor. it is used to protect the value reassign after initialization of a class
        /// </summary>
        public static readonly DateTime AppInitTime = DateTime.Now;
        /// <summary>
        /// Private variable or property or method can't access outside of the class
        /// Global private variable naming convention should start with underscore and camel case
        /// </summary>
        private MachineType _typeOfMachine = MachineType.UnKnown;
        private FuelType _typeOfFuel = FuelType.UnKnown;
        #endregion

        #region Constructor
        protected Vehicle()
        {
        }

        /// <summary>
        /// A Class can contain multiple constructor, but different input parameter
        /// It supports overload called Constructor overload
        /// Abstract class constructor we can call from derived class constructor using base keyword.
        /// </summary>
        /// <param name="name">name of the vehicle model like Pulsar or apache</param>
        /// <param name="companyName">The Company who manufactured the vehicle like Tata or Hyundai or Mahindra</param>
        /// <param name="cC">CC defines the output power of engine</param>
        /// <param name="typeOfMachine">typeOfMachine defines whether vehile is Engine or motor model</param>
        /// <param name="typeOfFuel">typeOfFuel defines vehicle Fuel Type like Electric or Diesel or else any other fuels </param>
        protected Vehicle(string name, Brand companyName, int cC, MachineType typeOfMachine, FuelType typeOfFuel)
        {
            Name = name;
            CompanyName = companyName;
            CC = cC;
            _typeOfMachine = typeOfMachine;
            _typeOfFuel = typeOfFuel;
        }
        #endregion

        #region Field Definitions
        internal const string TypeOfObject = "Vehicle";
        public abstract VehicleType TypeOfVehicle { get; set; }
        public string Name { get; set; }
        public string ChaseNumber { get; set; }
        public virtual int ManufactureYear { get; set; }
        public virtual System.Drawing.Color Color { get; set; }
        public virtual int NumberOfWheels { get; set; }
        public virtual Brand CompanyName { get; set; }
        public virtual int CC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public MachineType TypeOfMachine
        {
            get
            {
                return _typeOfMachine;
            }
            set
            {
                if ((_typeOfFuel == FuelType.Diesel || _typeOfFuel == FuelType.Petrol) && value == MachineType.Motor)
                {
                    throw new ArgumentException("FuelType should not be Diesel or Petrol when select machine type as motor");
                }
                else _typeOfMachine = value;
            }
        }
        public FuelType TypeOfFuel
        {
            get
            {
                return _typeOfFuel;
            }
            set
            {
                if (_typeOfMachine == MachineType.Engine && value == FuelType.Electric)
                {
                    throw new ArgumentException("Machine type should not be Engine when select Fuel Type as electric");
                }
                else _typeOfFuel = value;
            }
        }
        #endregion

        #region Method Definitions
        protected virtual string VehicleInfo()
        {
            return $"The vehicle name is {Name}! which is developed by {CompanyName} and its released on {ManufactureYear}.";
        }

        public override string ToString()
        {
            var st = base.ToString();
            return $"Name::{Name};ChaseNumber::{ChaseNumber};ManufactureYear::{ManufactureYear};Color::{Color.Name};NumberOfWheels::{NumberOfWheels};CompanyName::{CompanyName};";
        }

        public virtual bool IsValid(string properties = "")
        {
            Console.WriteLine(ToString() + properties);
            bool isValid = true;
            if (TypeOfVehicle == VehicleType.UnKnown)
            {
                Console.WriteLine("TypeofVehicle is not defined");
                isValid = false;
            }
            if (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Name is not defined");
                isValid = false;
            }
            if (string.IsNullOrEmpty(ChaseNumber))
            {
                Console.WriteLine("ChaseNumber is not defined");
                isValid = false;
            }
            if (ManufactureYear < 2000)
            {
                Console.WriteLine("ManufactureYear is not defined");
                isValid = false;
            }
            if (Color == Color.Empty)
            {
                Console.WriteLine("Color is not defined");
                isValid = false;
            }
            if (NumberOfWheels <= 1)
            {
                Console.WriteLine("NumberOfWheels is not defined");
                isValid = false;
            }
            if (CompanyName == Brand.UnKnown)
            {
                Console.WriteLine("CompanyName is not defined");
                isValid = false;
            }
            if (CC < 50)
            {
                Console.WriteLine("CC is not defined");
                isValid = false;
            }
            if (TypeOfMachine == MachineType.UnKnown)
            {
                Console.WriteLine("TypeOfMachine is not defined");
                isValid = false;
            }
            if (TypeOfFuel == FuelType.UnKnown)
            {
                Console.WriteLine("TypeOfFuel is not defined");
                isValid = false;
            }
            return isValid;
        }
        #endregion

        #region Operator definitions
        public static bool operator ==(Vehicle a, Vehicle b)
        {
            if (a.TypeOfVehicle == b.TypeOfVehicle && a.ManufactureYear == b.ManufactureYear && a.CompanyName == b.CompanyName && a.CC == b.CC && a.Color == b.Color)
                return true;
            else return false;
        }

        public static bool operator !=(Vehicle a, Vehicle b)
        {
            return !(a == b);
        }
        #endregion
    }



}
