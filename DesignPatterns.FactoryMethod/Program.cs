using DesignPatterns.FactoryMethod.Factory;

var windowsMessageBox = new WindowsMessageBox();
windowsMessageBox.Render();

var androidMessageBox = new AndroidMessageBox();
androidMessageBox.Render();

var iosMessageBox = new IosMessageBox();
iosMessageBox.Render();