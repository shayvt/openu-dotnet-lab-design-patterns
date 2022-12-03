using DesignPatterns.FactoryMethod.Model;

namespace DesignPatterns.FactoryMethod.Factory;

internal class IosMessageBox : MessageBox
{
    public override UiButton CreateUiButton()
    {
        return new IosUiButton();
    }
}
