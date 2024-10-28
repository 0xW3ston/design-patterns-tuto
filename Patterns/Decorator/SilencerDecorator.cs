using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using syntaxApp.Patterns.Decorator;

namespace syntaxApp.Patterns.Decorator
{
    public class SilencerDecorator: IGunDecorator
    {
        private IGun _gun;
        public SilencerDecorator(IGun gun) {
            _gun = gun;
        }
        public string GetName()
        {
            return _gun.GetName() + " + Silencer";
        }

        public void Reload()
        {
            _gun.Reload();
        }

        public void AimDown()
        {
            _gun.AimDown();
            Console.Write("<[with a silencer]>");
        }

        public void Shoot()
        {
            _gun.Shoot();
            Console.Write("<[quietely]>");
        }
    }
}
