using DesignPatterns.FactoryMethod.Problem;

AndroidMessageBox androidMessageBox = new();
androidMessageBox.Render();

WindowsMessageBox windowsMessageBox = new();
windowsMessageBox.Render();
