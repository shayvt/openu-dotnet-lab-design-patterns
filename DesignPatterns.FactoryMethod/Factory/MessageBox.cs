namespace DesignPatterns.FactoryMethod.Factory;

internal abstract class MessageBox
{
    public void Render()
    {
        Console.WriteLine("---- Rendering Message Box UI according to operating system ----");

        var button = CreateUiButton();
        button.Render();

        Console.WriteLine("-------------------------- Rendered ---------------------------");
    }

    public abstract UiButton CreateUiButton();
}
