using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class ProductComponent
    {
        // "Composite" methods
        public virtual void add(ProductComponent productComponent) { 
            
        }
        public virtual void remove(ProductComponent productComponent) { 
            
        }
        public ProductComponent getChild(int i) {
            throw new Exception();
        }

        // "operation" methods, used by Products
        public abstract string GetName();
        public abstract double GetPrice();
    }
}
