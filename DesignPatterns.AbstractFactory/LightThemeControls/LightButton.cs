using DesignPatterns.AbstractFactory.AbstractControls;

namespace DesignPatterns.AbstractFactory.LightThemeControls;

internal class LightButton : Button
{
    public override void Render()
    {
        Console.WriteLine("Render Light Button");
    }
}
