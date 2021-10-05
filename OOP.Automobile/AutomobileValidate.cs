using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using OOP.Automobile.Vehicles.Bikes;
using OOP.Automobile.Vehicles.Buses;
using OOP.Automobile.Vehicles.Cars.Diesels;
using OOP.Automobile.Vehicles.General;
using System;
using System.Drawing;

namespace OOP.Terminal
{
    public class AutomobileValidate
    {
        public void CheckCarInstance()
        {
            HyundaiCretaDieselCar car1 = new HyundaiCretaDieselCar();
        }
        public void CheckIsValid()
        {
            HyundaiCretaDieselCar car1 = new HyundaiCretaDieselCar();
            bool isValid = car1.IsValid();

            car1.ChaseNumber = "FT$%78IK";
            car1.Color = System.Drawing.Color.AliceBlue;
            car1.ManufactureYear = 2001;
            isValid = car1.IsValid();
        }

        public void CheckInterfaceUse()
        {
            HyundaiCretaDieselCar car1 = new HyundaiCretaDieselCar();
            car1.IgnitionType = Automobile.Enums.IgnitionQuality.Bad;
            MahindraTharDieselCar m1 = new MahindraTharDieselCar();
            IDieselCar car2 = car1;
            car2 = m1;
            car2.IgnitionType = Automobile.Enums.IgnitionQuality.Bad;

            IEngineCar car3 = car1;
            // car3.IgnitionType
            car3.IsHigherFuelEfficiency = true;
            ICar car4 = car1;

            IVehicle car5 = car1;
        }

        public void CheckToString()
        {
            MahindraTharDieselCar m1 = new MahindraTharDieselCar();
            Console.WriteLine(m1.ToString());
        }

        public void CheckOperatorOverload()
        {
            MahindraTharDieselCar m1 = new MahindraTharDieselCar();
            MahindraTharDieselCar m2 = new MahindraTharDieselCar();
            if (m1 == m2)
            {
                Console.WriteLine("Both are equal");
            }
            MahindraTharDieselCar m3 = new MahindraTharDieselCar();
            m3.Color = System.Drawing.Color.Teal;
            MahindraTharDieselCar m4 = new MahindraTharDieselCar();
            if (m3 != m4)
            {
                Console.WriteLine("Both are not equal");
            }

            HyundaiCretaDieselCar car1 = new HyundaiCretaDieselCar();
            if (car1 != m4)
            {
                Console.WriteLine("Both are not equal");
            }
        }


        public void CheckVehicleTypeException()
        {
            try
            {
                HyundaiCretaDieselCar car1 = new HyundaiCretaDieselCar();
                car1.TypeOfVehicle = Automobile.Enums.VehicleType.Bike;
            }
            catch (ArgumentException e)
            {

                throw;
            }
        }

        public void CheckPSversion()
        {
            ActivaBike bike1 = new ActivaBike();
            //bike1.PSVersion = 4


        }

        public void CheckObjectTypeConversion()
        {
            HornetBike bike1 = new HornetBike();

            string name = bike1;

            string bikeName = "myHornet";
            HornetBike bike2 = (HornetBike)bikeName;
        }

        public void CheckOverrideIsValid()
        {
            MahindraComfioBus bus1 = new MahindraComfioBus();
            bool isValid = bus1.IsValid();
            Console.WriteLine(isValid);

            bus1.ChaseNumber = "HHUIO";
            bus1.ManufactureYear = 2007;
            bus1.Color = Color.Green;
            bus1.NumberOfWheels = 6;

            bus1.TypeOfSeat = SeaterType.Unknown;
            isValid = bus1.IsValid();
            Console.WriteLine(isValid);

            bus1.TypeOfSeat = SeaterType.NormalSeating;
            isValid = bus1.IsValid();
            Console.WriteLine(isValid);

        }

        public void CheckDelegate()
        {
            HyundaiCretaDieselCar car1 = new HyundaiCretaDieselCar();
            car1.IsAcAvailable = true;
            car1.AcStatusChanged += TerminalMethod1;
            car1.IsAcAvailable = false;
            car1.IsAcAvailable = true;
            car1.IsAcAvailable = false;
            MahindraTharDieselCar car2 = new MahindraTharDieselCar();
            car2.AcStatusChanged += TerminalMethod2;
            car2.IsAcAvailable = true;
            TataNexonDieselCar car3 = new TataNexonDieselCar();
            car3.AcStatusChanged += TerminalMethod2;
            car3.IsAcAvailable = true;
        }

        private void TerminalMethod1()
        {
            Console.WriteLine("AcStatusChanged1");
        }

        private void TerminalMethod2()
        {
            Console.WriteLine("AcStatusChanged2");
        }


        public void CheckCustomDelegate()
        {
            MahindraComfioBus bus1 = new MahindraComfioBus();
            bus1.SeatTypeChanged += Bus1_SeatTypeChanged;
            bus1.TypeOfSeat = SeaterType.Sleeper;
        }

        private void Bus1_SeatTypeChanged(object sender, SeatTypeChangedEventArgs e)
        {
            Console.WriteLine($"OldSeatType::{e.OldSeatType} NewSeatType::{e.NewSeatType}");
        }
    }
}
