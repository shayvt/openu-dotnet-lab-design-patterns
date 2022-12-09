using DesignPatterns.Builder.Builders;
using DesignPatterns.Builder.Model;

namespace DesignPatterns.Builder.Directors
{
    internal class FamilyCarDirector
    {
        public void MakeCar(ICarBuilder builder)
        {
            builder.Reset();
            builder.SetEngine(new EngineFourCylinders() { Capacity = 1500 });
            builder.SetSeats(new Seats { Count = 5 });
            builder.SetAirBagCount(6);
        }
    }
}
