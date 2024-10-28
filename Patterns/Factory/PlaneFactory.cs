using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Factory
{
    public class PlaneFactory: IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Plane();
        }
    }
}
