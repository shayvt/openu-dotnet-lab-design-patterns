using DesignPatterns.AbstractFactory.AbstractControls;

namespace DesignPatterns.AbstractFactory.DarkThemeControls;

internal class DarkPanel : Panel
{
    public override void Render()
    {
        Console.WriteLine("Render Dark Panel");
    }
}
