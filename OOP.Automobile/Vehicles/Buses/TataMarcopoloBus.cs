﻿using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Buses
{

    public sealed class TataMarcopoloBus : Bus, IBus
    {
        public TataMarcopoloBus() : base(VehicleName.Marcopolo, Brand.Tata, 2000, SeaterType.NormalSeating, 40)
        {

        }

        public sealed override int ManufactureYear
        {
            get
            {
                if (base.ManufactureYear <= 2015)
                    return 2017;
                else return base.ManufactureYear;
            }
        }

    }
}
