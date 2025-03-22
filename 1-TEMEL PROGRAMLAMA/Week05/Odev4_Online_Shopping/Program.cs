namespace Odev4_Online_Shopping;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Shopping");
        Console.WriteLine("---------------");

        ShoppingCart shoppingCart = new ShoppingCart();

        shoppingCart.AddToCart(new Product("Kalem", 45));
        shoppingCart.AddToCart(new Product("Kitap", 145));
        shoppingCart.AddToCart(new Product("Defter", 450));
        shoppingCart.AddToCart(new Product("Mouse", 415));
        shoppingCart.AddToCart(new Product("Kumanda", 75));

        shoppingCart.Display();

        shoppingCart.RemoveProduct("Defter");
        shoppingCart.Display();

        shoppingCart.RemoveProduct("Bilgisayar");
        shoppingCart.Display();
    }
}
