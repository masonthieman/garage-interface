using System;
namespace Garage
{
    public interface IGasVehicle
    {
        void RefuelTank();
        int CurrentTankPercentage {get; set; }
    }
}