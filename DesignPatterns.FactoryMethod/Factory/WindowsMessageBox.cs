namespace DesignPatterns.FactoryMethod.Factory;

internal class WindowsMessageBox : MessageBox
{
    public override UiButton CreateUiButton()
    {
        return new WindowsUiButton();
    }
}
