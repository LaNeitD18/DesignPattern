using FactoryMethod.products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.creators
{
    public abstract class ButtonFactory
    {
        public abstract IButton create();
    }
}
