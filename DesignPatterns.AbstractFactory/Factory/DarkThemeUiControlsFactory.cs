using DesignPatterns.AbstractFactory.AbstractControls;
using DesignPatterns.AbstractFactory.DarkThemeControls;

namespace DesignPatterns.AbstractFactory.Factory;

internal class DarkThemeUiControlsFactory : IUiControlsFactory
{
    public Button CreateButton()
    {
        return new DarkButton();
    }

    public Checkbox CreateChecbox()
    {
        return new DarkCheckbox();
    }

    public Panel CreatePanel()
    {
        return new DarkPanel();
    }
}
