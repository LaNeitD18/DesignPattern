using Facade.Subsystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class HomeFacade
    {
        protected Light light;
        protected Television television;
        protected AirConditioner airConditioner;

        HomeFacade() { }
        public HomeFacade(Light light, Television tv, AirConditioner ac) {
            this.light = light;
            this.television = tv;
            this.airConditioner = ac;
        }

        public string turnOnAllDevices() {
            string res = "Facade initializes subsystems:\n";
            res += light.turnOn();
            res += television.turnOn();
            res += airConditioner.turnOn();
            return res;
        }

        public string turnOffAllDevices()
        {
            string res = "Facade turn off subsystems:\n";
            res += light.turnOff();
            res += television.turnOff();
            res += airConditioner.turnOff();
            return res;
        }
    }
}
