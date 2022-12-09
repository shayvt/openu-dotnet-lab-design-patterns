namespace DesignPatterns.Builder.Model;

public class Engine
{
    public int Capacity { get; set; }

    public override string ToString() => $"{Capacity} CC";
}
