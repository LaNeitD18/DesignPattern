using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Subsystem
{
    public class Television
    {
        private bool isTurningOn = false;
        public string turnOn() {
            isTurningOn = true;
            return "Television turned on.\n";
        }
        public string turnOff()
        {
            isTurningOn = false;
            return "Television turned off.\n";
        }

        public string switchChannel(int channel) {
            if(isTurningOn) {
                return $"Switched to channel {channel}\n";
            }
            return "Turn on to switch channel.\n";
        }
    }
}
