using AbstractFactory.products;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.factories
{
    class WinformStyleFactory : IAbstractFactory
    {
        public IButton createButton()
        {
            return new WinformStyleButton();
        }

        public IText createText()
        {
            return new WinformStyleText();
        }
    }
}
