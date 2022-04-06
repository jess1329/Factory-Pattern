using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Vehicles
{
    public class Car : IVehicle
    {
        public Car() 
        {
        }

        public void Drive() 
        {
            Console.WriteLine("The Car is driving! Wooo!");
        }



    }
}
