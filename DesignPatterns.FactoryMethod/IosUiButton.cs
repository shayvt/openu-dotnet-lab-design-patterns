namespace DesignPatterns.FactoryMethod;

internal class IosUiButton : UiButton
{
    public override void Render()
    {
        Console.WriteLine("IOS UI Button");
    }
}