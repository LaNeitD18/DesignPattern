using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.products
{
    class WinformStyleButton : IButton
    {
        public void renderButton()
        {
            Console.WriteLine("Winform style Button");
        }
    }
}
