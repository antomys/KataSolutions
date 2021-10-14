using BuyingCar.Interfaces;

namespace BuyingCar
{
    public class Car : ICar
    {
        public IFuelTankDisplay FuelTankDisplay;
        private IEngine _engine;
        private IFuelTank _fuelTank;

        public Car(double fuelLevel, IEngine engine, IFuelTank fuelTank)
        {
            _engine = engine;
            _fuelTank = fuelTank;
        }
    }
}