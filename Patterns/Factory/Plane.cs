using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Factory
{
    public class Plane: IVehicle
    {
        public string printVehiculeDescription()
        {
            Console.WriteLine($"The vehicle is a Plane");
            return $"The vehicle is a Plane";
        }
    }
}
