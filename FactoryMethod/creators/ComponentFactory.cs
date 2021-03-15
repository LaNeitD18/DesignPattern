using FactoryMethod.products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.creators
{
    public abstract class ComponentFactory
    {
        public abstract IComponent create();
    }
}
