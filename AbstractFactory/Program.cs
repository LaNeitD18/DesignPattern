using System;
using AbstractFactory.factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAbstractFactory componentFactory = null;

            // render material style button & text
            componentFactory = new MaterialStyleFactory();
            componentFactory.createButton().renderButton();
            componentFactory.createText().renderText();

            // render winform style button & text
            componentFactory = new WinformStyleFactory();
            componentFactory.createButton().renderButton();
            componentFactory.createText().renderText();
        }
    }
}
