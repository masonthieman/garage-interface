using System;
namespace Garage
{
    public class Ram : IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; } = 100;

        public void RefuelTank()
        {
           CurrentTankPercentage = 100;
        }

        
    }
}