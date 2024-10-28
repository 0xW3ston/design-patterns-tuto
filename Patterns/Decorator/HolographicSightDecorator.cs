using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Decorator
{
    public class HolographicSightDecorator: IGunDecorator
    {
        private IGun _gun;
        public HolographicSightDecorator(IGun gun)
        {
            _gun = gun;
        }

        public string GetName()
        {
            return _gun.GetName() + " + Holographic sight";
        }

        public void Reload()
        {
            _gun.Reload();
        }

        public void AimDown()
        {
            _gun.AimDown();
            Console.Write("<[with a holographic sight]>");
        }

        public void Shoot()
        {
            _gun.Shoot();
        }
    }
}
