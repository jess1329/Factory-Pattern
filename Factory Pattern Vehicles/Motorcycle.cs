﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Vehicles
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle() 
        {
        }
        public void Drive() 
        {
            Console.WriteLine("The Motorcycle is revving up!");
        }






    }
}
