using DesignPatterns.FactoryMethod.Model;

namespace DesignPatterns.FactoryMethod.Factory;

internal abstract class MessageBox
{
    public void Render()
    {
        Console.WriteLine("---- Rendering Message Box Logic ----");

        var button = CreateUiButton();
        button.Render();

        Console.WriteLine("---------- Rendered ---------------\r\n");
    }

    public abstract UiButton CreateUiButton();
}
