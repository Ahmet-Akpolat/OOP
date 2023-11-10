namespace OOP_1
{
     class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 3;
            product1.ProductName = "Desktop";
            product1.UnitPrice = 200;
            product1.UnitInStock = 10;

            Product product2 = new Product{Id = 2, CategoryId = 2, ProductName = "Phone", UnitPrice = 600, UnitInStock = 80};

            // C# Case Sensitive ( Büyük Küçük Duyarlı ) bir programlama dilidir
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);

            //Referans Tip
            Number num = new Number();
            num.Num = 9;
            productManager.DoSomething(num);
            Console.WriteLine(num.Num);

            // Değer tip
            int num2 = 9;
            num2 *= num2;
            Console.WriteLine(num2);

            // Değer tip
            int num3 = 9;
            productManager.DoSomething(num3);
            Console.WriteLine(num3);

            // İnteger değer döndürdüğü için bu metodu başka yerlerde de kullababilirim
            Console.WriteLine(productManager.Mul(2, 4) * 2);

            // Örnek
            int result = productManager.Mul(365, 7);
            Console.WriteLine(result / 30);

            productManager.Mul2(3,8); // Bu metodu başka yerde kullanamam, çalışır ve biter.

            //int,double,bool.... değer tip
            // diziler,classlar,abstract class, interace(arayüz), inheritance(kalıtım) referans tiplerdir.
            // değer tiplerde işlemlerde sadece aktarılır ve bağlantı sonlanır ama referans tiplerde referansın bellekteki adresiyle işlemeler yapılır.
        }
    }
}