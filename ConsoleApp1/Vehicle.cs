using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Vehicle
    {
        protected string Brand { get; set; }
        protected string Model { get; set; }


        protected virtual Program.VehicleType GetVehicleType()
        {
            return Program.VehicleType.Air;
        }

        public virtual int GetVehicleRange(Program.FuelType fuelType, int amount)
        {
            return 1;
        }

        public string GetDescription()
        {
            return $"This is {Brand} {Model} which move on {GetVehicleType()}";
        }
    }

    
}
