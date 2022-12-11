using DesignPatterns.AbstractFactory.AbstractControls;

namespace DesignPatterns.AbstractFactory.Factory;

internal interface IUiControlsFactory
{
    Button CreateButton();

    Checkbox CreateChecbox();

    Panel CreatePanel();
}
