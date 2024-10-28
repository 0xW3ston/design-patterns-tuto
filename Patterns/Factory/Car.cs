using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Factory
{
    internal class Car: IVehicle
    {
        public string printVehiculeDescription()
        {
            Console.WriteLine($"The vehicle is a Car");
            return $"The vehicle is a Car";
        }
    }
}
