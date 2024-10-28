using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Facade
{
    public class LightSystem
    {
        public void TurnOnLights() => Console.WriteLine("Lights are on.");
        public void TurnOffLights() => Console.WriteLine("Lights are off.");
    }

    public class MusicSystem
    {
        public void PlayMusic() => Console.WriteLine("Playing music.");
        public void StopMusic() => Console.WriteLine("Music stopped.");
    }

    public class SecuritySystem
    {
        public void ArmSystem() => Console.WriteLine("Security system armed.");
        public void DisarmSystem() => Console.WriteLine("Security system disarmed.");
    }
}
