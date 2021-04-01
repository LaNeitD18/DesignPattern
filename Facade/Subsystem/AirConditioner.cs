using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Subsystem
{
    public class AirConditioner
    {
        public string turnOn() {
            return "Air conditioner turned on.\n";
        }
        public string turnOff() {
            return "Air conditioner turned off.\n";
        }
    }
}
