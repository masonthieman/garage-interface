using System;
namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"Turning to the {direction}.");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"Coming to a stop");
        }
    }
}