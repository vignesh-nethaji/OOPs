using OOP.Automobile.Interfaces;
using OOP.Automobile.Vehicles.Cars.Electrics;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace OOP.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BuildMotors buildMotors = new BuildMotors();
            buildMotors.ElectricCars();

            AutomobileValidate automobileValidate = new AutomobileValidate();
            automobileValidate.CheckCarInstance();
            //automobileValidate.CheckIsValid();
            //automobileValidate.CheckToString();
            //automobileValidate.CheckOperatorOverload();
            //automobileValidate.CheckVehicleTypeException();
            //automobileValidate.CheckPSversion();
            //automobileValidate.CheckObjectTypeConversion();
            //automobileValidate.CheckOverrideIsValid();
            //automobileValidate.CheckDelegate();
            //automobileValidate.CheckCustomDelegate();

           

        }
    }


    public class BuildMotors
    {
        private readonly List<IVehicle> vehicles = new List<IVehicle>();
        public void ElectricCars()
        {
            AudiETronElectricCar audiETronElectricCar1 = new AudiETronElectricCar();
            audiETronElectricCar1.ManufactureYear = 2018;
            audiETronElectricCar1.ChaseNumber = "0XA1";
            audiETronElectricCar1.Color = Color.AliceBlue;
            audiETronElectricCar1.AcStatusChanged += AudiETronElectricCar1_AcStatusChanged;
            audiETronElectricCar1.IsAcAvailable = true;
            Console.WriteLine(audiETronElectricCar1.IsValid());

            AudiETronElectricCar audiETronElectricCar2 = new AudiETronElectricCar();
            audiETronElectricCar2.ManufactureYear = 2018;
            audiETronElectricCar2.ChaseNumber = "0XB1";
            audiETronElectricCar2.Color = Color.Red;
            audiETronElectricCar2.AcStatusChanged += AudiETronElectricCar2_AcStatusChanged;
            audiETronElectricCar2.IsAcAvailable = true;
            Console.WriteLine(audiETronElectricCar1.IsValid());
            if (audiETronElectricCar1 == audiETronElectricCar2)
            {
                Console.WriteLine("Car are equal");
            }
            else
            {
                Console.WriteLine("Car are not equal");

            }
            vehicles.Add(audiETronElectricCar1);


        }

        private void AudiETronElectricCar1_AcStatusChanged()
        {
            Console.WriteLine("Ac status Changed - First Event trigger method calling");
        }

        private void AudiETronElectricCar2_AcStatusChanged()
        {
            Console.WriteLine("Ac status Changed - Second Event trigger method calling");
        }
    }


}
