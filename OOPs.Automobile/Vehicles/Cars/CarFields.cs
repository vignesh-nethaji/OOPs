using OOPs.Automobile.Enums;
using OOPs.Automobile.Interfaces;
using System;

namespace OOPs.Automobile.Vehicles.Cars
{
    public partial class Car : Vehicle, ICar
    {
        public event Action AcStatusChanged;
        private bool _isAcAvailable;
        public override VehicleType TypeOfVehicle
        {
            get
            {
                return _typeofVehicle;
            }
            set
            {
                throw new ArgumentException("Already vehicle type defined as Car. Don't try to set it");
            }
        }

        public bool IsAcAvailable
        {
            get
            {
                return _isAcAvailable;
            }
            set
            {
                if (_isAcAvailable != value)
                {
                    OnAcStatusChanged();
                }
                _isAcAvailable = value;
            }
        }
        public bool IsSunRoofAvailable { get; set; }

        public sealed override int NumberOfWheels
        {
            get
            {
                return _numberOfWheels;
            }
            set
            {
                throw new ArgumentException("Car wheels already defined we can't set it");
            }
        }

        protected virtual void OnAcStatusChanged()
        {
            //AcStatusChanged?.Invoke();
            if (AcStatusChanged != null)
            {
                AcStatusChanged();
            }
        }
    }
}
