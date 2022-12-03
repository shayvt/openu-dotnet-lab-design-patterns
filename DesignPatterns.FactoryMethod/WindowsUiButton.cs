using DesignPatterns.FactoryMethod.Model;

namespace DesignPatterns.FactoryMethod;

internal class WindowsUiButton : UiButton
{
    public override void Render()
    {
        Console.WriteLine("Windows UI Button");
    }
}
