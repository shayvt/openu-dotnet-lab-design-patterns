using DesignPatterns.AbstractFactory.AbstractControls;

namespace DesignPatterns.AbstractFactory.DarkThemeControls;

internal class DarkButton : Button
{
    public override void Render()
    {
        Console.WriteLine("Render Dark Button");
    }
}
