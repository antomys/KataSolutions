using BuyingCar.Interfaces;

namespace BuyingCar
{
    public class FuelTank : IFuelTank
    {
        private const double MaximalFuelCapacity = 60d;
        public double FuelLevel { get; }

        public FuelTank(double fuelLevel)
        {
            FuelLevel = fuelLevel > MaximalFuelCapacity ? MaximalFuelCapacity : fuelLevel;
        }
    }
}