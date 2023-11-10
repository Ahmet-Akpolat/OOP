using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class CartManager
    {
        //Naming Convention
        //Syntax
        public void Add(Product product)
        {
            Console.WriteLine("Congrats. Added to Cart! : " + product.Name);
        }

        public void Add2(string productName, string description, double price, int stocks)
        {
            Console.WriteLine("Congrats. Added to Cart! : " + productName);
        }
    }
}
