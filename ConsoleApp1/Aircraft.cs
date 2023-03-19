using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Aircraft :Vehicle
    {
        protected override Program.VehicleType GetVehicleType()
        {
            return Program.VehicleType.Air;
        }
    }
}
