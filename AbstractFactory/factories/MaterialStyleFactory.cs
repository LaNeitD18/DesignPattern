using AbstractFactory.products;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.factories
{
    class MaterialStyleFactory : IAbstractFactory
    {
        public IButton createButton()
        {
            return new MaterialStyleButton();
        }

        public IText createText()
        {
            return new MaterialStyleText();
        }
    }
}
