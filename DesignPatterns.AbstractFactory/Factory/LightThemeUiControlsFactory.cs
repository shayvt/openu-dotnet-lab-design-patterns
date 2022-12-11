using DesignPatterns.AbstractFactory.AbstractControls;
using DesignPatterns.AbstractFactory.LightThemeControls;

namespace DesignPatterns.AbstractFactory.Factory;

internal class LightThemeUiControlsFactory : IUiControlsFactory
{
    public Button CreateButton()
    {
        return new LightButton();
    }

    public Checkbox CreateChecbox()
    {
        return new LightCheckbox();
    }

    public Panel CreatePanel()
    {
        return new LightPanel();
    }
}
