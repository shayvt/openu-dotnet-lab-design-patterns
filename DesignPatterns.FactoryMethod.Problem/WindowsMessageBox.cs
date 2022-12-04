namespace DesignPatterns.FactoryMethod.Problem;

internal class WindowsMessageBox
{
    public void Render()
    {
        Console.WriteLine("---- Render message box logic ------");

        WindowsUiButton button = new();

        button.Render();

        Console.WriteLine("------- Completed render -----------\r\n");
    }
}
