using DesignPatterns.AbstractFactory.AbstractControls;

namespace DesignPatterns.AbstractFactory.LightThemeControls;

internal class LightPanel : Panel
{
    public override void Render()
    {
        Console.WriteLine("Render Light Panel");
    }
}
