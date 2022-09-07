using System;
namespace Garage
{
    public class Tesla : IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage {get; set; } = 100;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

       
    }
}