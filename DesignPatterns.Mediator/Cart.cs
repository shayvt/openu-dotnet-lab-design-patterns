namespace DesignPatterns.Mediator;

internal class Cart : ShoppingAppComponent
{
    private List<string> _products = new();

    public void AddProduct(string product)
    {
        _products.Add(product);
    }

    internal void ShowCart()
    {
        Console.WriteLine("****** Cart *******");

        foreach (var product in _products)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine("*******************");
    }
}
