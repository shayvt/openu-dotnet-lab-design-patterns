namespace DesignPatterns.FactoryMethod.Problem;

internal class AndroidMessageBox
{
    public void Render()
    {
        Console.WriteLine("---- Render message box logic ------");

        AndroidUiButton button = new();

        button.Render();

        Console.WriteLine("------- Completed render -----------\r\n");
    }
}
