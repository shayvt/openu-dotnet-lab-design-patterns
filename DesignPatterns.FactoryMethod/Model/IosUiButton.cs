namespace DesignPatterns.FactoryMethod.Model;

internal class IosUiButton : UiButton
{
    public override void Render()
    {
        Console.WriteLine("IOS UI Button");
    }
}