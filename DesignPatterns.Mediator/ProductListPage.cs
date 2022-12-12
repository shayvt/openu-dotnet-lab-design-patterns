namespace DesignPatterns.Mediator;

internal class ProductListPage : ShoppingAppComponent
{
    private List<string> _products = new()
    {
        "Oven",
        "Drill",
        "Screwdriver",
        "Oled TV",
        "Chair"
    };

    public void ShowProductList()
    {
        Console.WriteLine("**** Prodcut List Page ****");

        foreach (var product in _products)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine("**************************");
    }

    public void SelectProduct(string product)
    {
        AppMediator.ShowProductPage(product);
    }
}
