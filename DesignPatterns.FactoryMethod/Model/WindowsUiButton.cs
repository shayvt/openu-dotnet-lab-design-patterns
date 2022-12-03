namespace DesignPatterns.FactoryMethod.Model;

internal class WindowsUiButton : UiButton
{
    public override void Render()
    {
        Console.WriteLine("Windows UI Button");
    }
}
