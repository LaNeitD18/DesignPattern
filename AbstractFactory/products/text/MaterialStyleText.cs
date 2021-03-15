using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.products
{
    class MaterialStyleText : IText
    {
        public void renderText()
        {
            Console.WriteLine("Material style Text");
        }
    }
}
