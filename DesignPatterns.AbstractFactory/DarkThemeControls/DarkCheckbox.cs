using DesignPatterns.AbstractFactory.AbstractControls;

namespace DesignPatterns.AbstractFactory.DarkThemeControls;

internal class DarkCheckbox: Checkbox
{
    public override void Render()
    {
        Console.WriteLine("Render Dark Checkbox");
    }
}
