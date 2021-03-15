using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class SoundManager
    {
        private static SoundManager _instance;
        private List<string> listSound = new List<string>();

        private SoundManager() { }

        public static SoundManager getInstance()
        {
            // lazy init
            if(_instance == null) {
                _instance = new SoundManager();
            }
            return _instance;
        }

        public void addSound(string soundName) {
            listSound.Add(soundName);
            Console.WriteLine("Added sound successfully!");
        }

        public void playSound(int index) { 
            if(index < listSound.Count) {
                Console.WriteLine("Playing sound: " + listSound[index]);
            } else {
                Console.WriteLine("Sound invalid");
            }
        }

        public int getNumberOfSounds() {
            return this.listSound.Count;
        }
    }
}
