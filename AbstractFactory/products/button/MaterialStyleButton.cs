using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.products
{
    class MaterialStyleButton : IButton
    {
        public void renderButton()
        {
            Console.WriteLine("Material style Button");
        }
    }
}
