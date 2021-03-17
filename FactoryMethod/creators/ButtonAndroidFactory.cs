using FactoryMethod.products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.creators
{
    public class ButtonAndroidFactory : ButtonFactory
    {
        public override IButton create()
        {
            return new ButtonAndroid();
        }
    }
}
