namespace DesignPatterns.Mediator;

internal class ProductPage : ShoppingAppComponent
{
    private string _product;

    public void ShowProductPage(string product)
    {
        _product = product;
        Console.WriteLine("**** Product Page ****");
        Console.WriteLine(_product);
        Console.WriteLine("**********************");
    }

    public void AddProductToCart()
    {
        AppMediator.AddToCart(_product);
    }

    public void ShowCart()
    {
        AppMediator.ShowCart();
    }
}
