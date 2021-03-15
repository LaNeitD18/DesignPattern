using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.products
{
    public class Button : IComponent
    {
        public void render()
        {
            Console.WriteLine("I'm Button");
        }

        public void onClick() {
            Console.WriteLine("Yeah you can only click me!");
        }
    }
}
