using System;
using Facade.Subsystem;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            Television television = new Television();
            AirConditioner airConditioner = new AirConditioner();

            HomeFacade homeFacade = new HomeFacade(light, television, airConditioner);

            Console.WriteLine(homeFacade.turnOnAllDevices());
            Console.WriteLine(television.switchChannel(18));

            Console.WriteLine(homeFacade.turnOffAllDevices());
            Console.WriteLine(television.switchChannel(18));
        }
    }
}
