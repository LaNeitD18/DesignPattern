using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Product : ProductComponent
    {
        private string name;
        private double price;

        public Product() { }
        public Product(string name, double price) {
            this.name = name;
            this.price = price;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override double GetPrice()
        {
            return this.price;
        }
    }
}
