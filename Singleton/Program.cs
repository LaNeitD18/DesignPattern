using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundManager soundManager = SoundManager.getInstance();
            SoundManager temp = SoundManager.getInstance();

            soundManager.addSound("AAA");
            temp.addSound("ZZZ");

            soundManager.playSound(1);
        }
    }
}
