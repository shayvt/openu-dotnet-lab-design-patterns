using DesignPatterns.Builder.Builders;
using DesignPatterns.Builder.Model;

namespace DesignPatterns.Builder.Directors;

internal class SportCarDirector
{
    public void MakeCar(ICarBuilder builder)
    {
        builder.Reset();
        builder.SetEngine(new EngineV8() { Capacity = 3000 });
        builder.SetSeats(new Seats { Count = 4 });
        builder.SetAirBagCount(7);
        builder.SetRadar(true);
        builder.SetCruiseControl(true);
        builder.SetAlloyRims(true);
    }
}
