using DesignPatterns.Builder.Model;

namespace DesignPatterns.Builder.Builders;

internal class CarManualBuilder : ICarBuilder
{
    public CarManual CarManual { get; private set; }

    public void Reset()
    {
        CarManual = new();
    }

    public void SetAirBagCount(int airBagCount)
    {
        if (airBagCount > 0)
        {
            CarManual.CarManualChapter.Add("To disable passenger air bag, press the yellow button.");
        }
    }

    public void SetAlloyRims(bool alloyRims)
    {
        if (alloyRims)
        {
            CarManual.CarManualChapter.Add("Clean your rims gentely with microfiber and cleaning solution");
        }
    }

    public void SetCruiseControl(bool cruiseControl)
    {
        if (cruiseControl)
        {
            CarManual.CarManualChapter.Add("Cruise Control instructions");
        }
    }

    public void SetEngine(Engine engine)
    {
        string chapter = $"Your car has {engine.Capacity} CC engine.";

        if (engine.Capacity >= 1500 && engine.Capacity <= 2000)
        {
            chapter += "\r\nYou need to change oil once in a year. Use synthetic oil.";
        }

        if (engine.Capacity > 2000)
        {
            chapter += "\r\nYou need to change oil once in a 6 months. Use synthetic oil.";
        }

        CarManual.CarManualChapter.Add(chapter);
    }

    public void SetRadar(bool radar)
    {
        if (radar)
        {
            CarManual.CarManualChapter.Add("Radar system instructions");
        }
    }

    public void SetSeats(Seats seats)
    {
        CarManual.CarManualChapter.Add($"Your car has {seats.Count} seats.");
    }
}
