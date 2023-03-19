namespace ConsoleApp1
{
    public class GasolineCar : Car
    {
        public Program.FuelType fuelType { get; set; } = Program.FuelType.LPG;

        public Program.FuelType fuelType2 { get; set; } = Program.FuelType.Gasoline;
        public int Efficiency { get; set; }

        public void GetEfficiency(Program.FuelType fuelType)
        {
            if (fuelType == Program.FuelType.LPG)
            {
                Efficiency = 15;
            }

            if (fuelType == Program.FuelType.LPG)
            {
                Efficiency = 20;
            }
        }
    }
}