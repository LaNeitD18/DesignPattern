using AbstractFactory.products;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.factories
{
    public interface IAbstractFactory
    {
        IButton createButton();
        IText createText();
    }
}
