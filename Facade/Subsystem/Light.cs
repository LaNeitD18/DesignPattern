using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Subsystem
{
    public class Light
    {
        public string turnOn() {
            return "Light turned on.\n";
        }
        public string turnOff()
        {
            return "Light turned off.\n";
        }
    }
}
