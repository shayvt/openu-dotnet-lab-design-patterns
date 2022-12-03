namespace DesignPatterns.FactoryMethod;

internal class AndoridUiButton : UiButton
{
    public override void Render()
    {
        Console.WriteLine("Android UI Button");
    }
}
