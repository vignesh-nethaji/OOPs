﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Interfaces
{
    /// <summary>
    ///  interface :: (i) The class which implements the interface,
    ///                   must provide the implementation of all the methods declared inside the interface.
    ///               (ii) used to achive Multiple inheritance.   
    /// </summary>


    public interface IVehicle
    {
        string Name { get; set; }
        int Manufacture { get; set; }
        void Test();
    }

    public class Car : IVehicle
    {
        private string _carProperty;
        public string Name { get; set; }
        public int Manufacture { get; set; }

        public void Test()
        {

        }
        public string CarProperty
        {
            get
            {
                return _carProperty;
            }
            set
            {
                _carProperty = value;
            }
        }

    }

    public class Lorry : IVehicle
    {
        public string Name { get; set; }
        public int Manufacture { get; set; }
        public string LorryProperty { get; set; }

        public void Test()
        {
            //throw new NotImplementedException();
        }
    }

    public class Bus : IVehicle
    {
        public string Name { get; set; }
        public int Manufacture { get; set; }
        public string BusProperty { get; set; }

        public void Test()
        {
            //throw new NotImplementedException();
        }
    }

    public class ValidateInterface
    {
        public void Test()
        {
            Car car = new Car();
            car.Name = "Car1";
            car.Manufacture = 2017;
            car.CarProperty = "Car Properties";

            IVehicle iCar = new Car();
            iCar.Name = "ICar1";
            iCar.Manufacture = 2018;
            // iCar.CarProperty = "ICar Properties";

            Bus bus = new Bus();
            bus.Name = "Bus1";
            bus.Manufacture = 2013;
            bus.BusProperty = "Bus Properties";

            IVehicle iBus = new Bus();
            iBus.Name = "iBus1";
            iBus.Manufacture = 2008;
            //iBus.BusProperty = "iBus Properties";

            Lorry lorry = new Lorry();
            lorry.Name = "Lorry1";
            lorry.Manufacture = 2004;
            lorry.LorryProperty = "Lorry Properties";

            IVehicle iLorry = new Lorry();
            iLorry.Name = "iLorry1";
            iLorry.Manufacture = 2002;
            //iLorry.LorryProperty = "iLorry Properties";
        }
    }
}
