using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Decorator
{
    public class ExtendedMagazineDecorator: IGunDecorator
    {
        private IGun _gun;
        public ExtendedMagazineDecorator(IGun gun)
        {
            _gun = gun;
        }

        public string GetName()
        {
            return _gun.GetName() + " + Extended magazine";
        }

        public void Reload()
        {
            _gun.Reload();
        }

        public void AimDown()
        {
            _gun.AimDown();
        }

        public void Shoot()
        {
            _gun.Shoot();
            Console.Write("<[with an extended magazine]>");
        }
    }
}
