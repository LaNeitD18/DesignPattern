using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Box : ProductComponent
    {
        protected List<ProductComponent> _children = new List<ProductComponent>();

        public override void add(ProductComponent productComponent)
        {
            this._children.Add(productComponent);
        }

        public override void remove(ProductComponent productComponent)
        {
            this._children.Remove(productComponent);
        }

        public override string GetName()
        {
            string result = "Box( ";
            
            for(int i=0; i<this._children.Count; i++) {
                ProductComponent component = this._children[i];
                result += component.GetName();

                if(i != this._children.Count - 1) {
                    result += ", ";
                }
            }

            return result + ")";
        }

        public override double GetPrice()
        {
            double price = 0;

            for (int i = 0; i < this._children.Count; i++)
            {
                ProductComponent component = this._children[i];
                price += component.GetPrice();
            }

            return price;
        }
    }
}
