using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.products
{
    public class ButtonAndroid : IButton
    {
        public void render()
        {
            Console.WriteLine("I'm Button Android");
        }

        public void onClick() {
            Console.WriteLine("Click Android!");
        }
    }
}
