using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.products
{
    class WinformStyleText : IText
    {
        public void renderText()
        {
            Console.WriteLine("Winform style Text");
        }
    }
}
