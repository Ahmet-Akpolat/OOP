using System.Security.AccessControl;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Apple";
            product1.Price = 25;
            product1.Description = "Amasya Apple";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Description = "Diyarbakır Watermelon";

            Product product3 = new Product();
            product3.Id = 3;
            product3.Name = "Strawberry";
            product3.Price = 100;
            product3.Description = "Fresh Sweet Strawberries";
            product3.Stocks = 25;

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine("Product: " + product.Name);
                Console.WriteLine("Product Description: " + product.Description);
                Console.WriteLine("Product Price: " + product.Price + "TL");
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("---------Methods-------------");
            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            cartManager.Add(product2);
            cartManager.Add(product3);
            
            cartManager.Add2("Lemon", "Fresh Sour Lemon", 35, 10);
            cartManager.Add2("Orange", "Fresh Sweet Orange", 40, 100);
            cartManager.Add2("Banana", "Imported Banana", 100, 40);


            Console.ReadKey();
        }
    }
}