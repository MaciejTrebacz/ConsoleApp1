using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            GasolineCar myCar = new GasolineCar();
            Console.WriteLine(myCar.GetDescription());
        }
        public enum FuelType
        {
            Gasoline,
            LPG,
            Diesel,
            Electricity,
            Jet
        }

        public enum VehicleType
        {
            Land,
            Water,
            Air,
            Cosmic
        }
    }

}


    

