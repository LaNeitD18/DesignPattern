using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.products
{
    public class Text : IComponent
    {
        public void render()
        {
            Console.WriteLine("I'm Text");
        }
    }
}
