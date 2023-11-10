using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " is Added!");
        }

        public void DoSomething(Number number)
        {
            number.Num = number.Num * number.Num;
        }

        public void DoSomething(int number)
        {
            number *= number;
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " is Updated!");
        }

        // İnteger değer döndüren bir metot. Return ile değer döndürmesini sağlıyoruz.(İnteger method)
        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        // Değer döndürmeyen, çağırıldığında çalışıp biten bir metot.(void method)
        public void Mul2(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }

    }
}
