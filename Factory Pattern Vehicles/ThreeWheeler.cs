using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Vehicles
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler() 
        {
        }

        public void Drive() 
        {
            Console.WriteLine("Let's get going!");
        }




    }
}
