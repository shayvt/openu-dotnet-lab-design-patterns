using DesignPatterns.Builder.Model;

namespace DesignPatterns.Builder.Builders;

internal interface ICarBuilder
{
    void Reset();

    void SetEngine(Engine engine);

    void SetSeats(Seats seats);

    void SetAirBagCount(int airBagCount);

    void SetAlloyRims(bool alloyRims);

    void SetCruiseControl(bool cruiseControl);

    void SetRadar(bool radar);
}
