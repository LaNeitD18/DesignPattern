using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.products
{
    public class ButtonIOS : IButton
    {
        public void onClick()
        {
            Console.WriteLine("Click iOS");
        }

        public void render()
        {
            Console.WriteLine("I'm Button iOS");
        }
    }
}
