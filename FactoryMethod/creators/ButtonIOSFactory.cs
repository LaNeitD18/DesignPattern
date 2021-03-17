using FactoryMethod.products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.creators
{
    public class ButtonIOSFactory : ButtonFactory
    {
        public override IButton create()
        {
            return new ButtonIOS();
        }
    }
}
