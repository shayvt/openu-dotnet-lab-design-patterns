namespace DesignPatterns.Mediator;

internal class ShoppingAppMediator : IShoppingAppMediator
{
    private readonly Cart _cart;
    private readonly ProductPage _productPage;
    private readonly ProductListPage _productListPage;

    public ShoppingAppMediator(Cart cart, ProductPage productPage, ProductListPage productListPage)
    {
        _cart = cart;
        _productPage = productPage;
        _productListPage = productListPage;
    }

    public void AddToCart(string productName)
    {
        _cart.AddProduct(productName);
    }

    public void ShowCart()
    {
        _cart.ShowCart();
    }

    public void ShowProductListPage()
    {
        _productListPage.ShowProductList();
    }

    public void ShowProductPage(string productName)
    {
        _productPage.ShowProductPage(productName);
    }
}
