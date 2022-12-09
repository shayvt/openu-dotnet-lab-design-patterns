namespace DesignPatterns.Builder.Model;

public class CarManual
{
    public List<string> CarManualChapter { get; } = new();

    public override string ToString() => CarManualChapter.Aggregate("Car Manual\r\n=======\r\n", (acc, curr) => $"{acc}\r\n{curr}");
}
