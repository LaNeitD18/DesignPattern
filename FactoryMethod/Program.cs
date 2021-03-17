using FactoryMethod.creators;
using FactoryMethod.products;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ButtonFactory componentFactory = new ButtonAndroidFactory();

            IButton androidButton = componentFactory.create();
            androidButton.render();
            (androidButton as ButtonAndroid)?.onClick();

            componentFactory = new ButtonIOSFactory();
            IButton iOSButton = componentFactory.create();
            iOSButton.render();
        }
    }
}
