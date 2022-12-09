using DesignPatterns.Builder.Model;

namespace DesignPatterns.Builder.Builders;

internal class CarBuilder : ICarBuilder
{
    public Car Car { get; private set; }

    public void Reset()
    {
        Car = new();
    }

    public void SetAirBagCount(int airBagCount)
    {
        Car.AirBagCount = airBagCount;
    }

    public void SetAlloyRims(bool alloyRims)
    {
        Car.AlloyRims = alloyRims;
    }

    public void SetCruiseControl(bool cruiseControl)
    {
        Car.CruiseControl = cruiseControl;
    }

    public void SetEngine(Engine engine)
    {
        Car.Engine = engine;
    }

    public void SetRadar(bool radar)
    {
        Car.Radar = radar;
    }

    public void SetSeats(Seats seats)
    {
        Car.Seats = seats;
    }
}