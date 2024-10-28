using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Decorator
{
    public class BaseGun: IGun
    {
        private string _gunName;
        public BaseGun(string gunname) {
            _gunName = gunname;
        }

        public string GetName()
        {
            return _gunName;
        }
        public void AimDown()
        {
            Console.WriteLine($"\n\nAiming down...");
        }

        public void Reload()
        {
            Console.WriteLine($"\n\nReloading...");
        }

        public void Shoot()
        {
            Console.WriteLine($"\n\nShooting 1 Bullet");
        }
    }
}
