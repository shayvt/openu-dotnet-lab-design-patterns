using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Factory;

AppTheme appTheme = AppTheme.Light;
IUiControlsFactory uiControlFactory;

switch (appTheme)
{
    case AppTheme.Dark:
        uiControlFactory = new DarkThemeUiControlsFactory();
        break;
    case AppTheme.Light:
        uiControlFactory = new LightThemeUiControlsFactory();
        break;
    default:
        uiControlFactory = new LightThemeUiControlsFactory();
        break;
}

uiControlFactory.CreatePanel().Render();
uiControlFactory.CreateButton().Render();
uiControlFactory.CreateChecbox().Render();