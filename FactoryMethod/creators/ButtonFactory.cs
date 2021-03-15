using FactoryMethod.products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.creators
{
    public class ButtonFactory : ComponentFactory
    {
        public override IComponent create()
        {
            return new Button();
        }
    }
}
