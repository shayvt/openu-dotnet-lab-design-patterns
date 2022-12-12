using DesignPatterns.Mediator;

Cart cart = new();
ProductPage productPage = new();
ProductListPage productListPage = new();

IShoppingAppMediator shoppingAppMediator = new ShoppingAppMediator(cart, productPage, productListPage);

cart.AppMediator = shoppingAppMediator;
productPage.AppMediator = shoppingAppMediator;
productListPage.AppMediator = shoppingAppMediator;

productListPage.ShowProductList();

productListPage.SelectProduct("Drill");
productPage.AddProductToCart();

productListPage.SelectProduct("Oled TV");
productPage.AddProductToCart();

cart.ShowCart();