namespace DesignPatterns.Builder.Model;

public class Car
{
    public Engine Engine { get; set; }

    public Seats Seats { get; set; }

    public int AirBagCount { get; set; }

    public bool Radar { get; set; }

    public bool CruiseControl { get; set; }

    public bool AlloyRims { get; set; }

    public Car()
    {
    }

    public Car(Engine engine, Seats seats) : this(engine, seats, 0, false, false, false)
    {
    }

    public Car(Engine engine, Seats seats, int airBagCount) : this(engine, seats, airBagCount, false, false, false)
    {
    }

    public Car(Engine engine, Seats seats, int airBagCount, bool radar, bool cruiseControl, bool alloyRims)
    {
        Engine = engine;
        Seats = seats;
        AirBagCount = airBagCount;
        Radar = radar;
        CruiseControl = cruiseControl;
        AlloyRims = alloyRims;
    }

    public override string ToString() => $"Engine: {Engine}, Seats: {Seats}, AirBags: {AirBagCount}, Radar: {Radar}, CriuseControl: {CruiseControl}, AlloyReams: {AlloyRims}";
}
