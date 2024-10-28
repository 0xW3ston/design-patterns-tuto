using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Facade
{
    public class HomeAutomationFacade
    {
        private LightSystem _lights;
        private MusicSystem _music;
        private SecuritySystem _security;

        public HomeAutomationFacade()
        {
            _lights = new LightSystem();
            _music = new MusicSystem();
            _security = new SecuritySystem();
        }

        public void LeaveHome()
        {
            _lights.TurnOffLights();
            _music.StopMusic();
            _security.ArmSystem();
            Console.WriteLine("Home is in 'leave' mode.");
        }

        public void EnterHome()
        {
            _security.DisarmSystem();
            _lights.TurnOnLights();
            _music.PlayMusic();
            Console.WriteLine("Home is in 'enter' mode.");
        }
    }
}
