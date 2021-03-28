using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Client
    {
        public void calcProductPrice(Product product) {
            Console.WriteLine($"Result(name: {product.GetName()}, price: {product.GetPrice()})");
        }

        public void calcTotalPrice(Box box) {
            Console.WriteLine($"Result(name: {box.GetName()}, price: {box.GetPrice()})");
        }
    }
}
