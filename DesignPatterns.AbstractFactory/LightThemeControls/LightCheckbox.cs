using DesignPatterns.AbstractFactory.AbstractControls;

namespace DesignPatterns.AbstractFactory.LightThemeControls;

internal class LightCheckbox : Checkbox
{
    public override void Render()
    {
        Console.WriteLine("Render Light Checkbox");
    }
}
