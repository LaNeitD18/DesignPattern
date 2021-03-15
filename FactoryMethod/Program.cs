using FactoryMethod.creators;
using FactoryMethod.products;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ComponentFactory componentFactory = new ButtonFactory();

            IComponent button = componentFactory.create();
            button.render();
            (button as Button)?.onClick();

            componentFactory = new TextFactory();
            IComponent text = componentFactory.create();
            text.render();
        }
    }
}
