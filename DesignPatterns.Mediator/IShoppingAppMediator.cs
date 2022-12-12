namespace DesignPatterns.Mediator;

internal interface IShoppingAppMediator
{
    void ShowProductPage(string productName);
    void ShowProductListPage();
    void AddToCart(string productName);
    void ShowCart();
}
