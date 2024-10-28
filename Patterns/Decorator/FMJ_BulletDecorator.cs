namespace syntaxApp.Patterns.Decorator
{
    public class FMJ_BulletDecorator : IGunDecorator
    {
        private IGun _gun;
        public FMJ_BulletDecorator(IGun gun)
        {
            _gun = gun;
        }

        public string GetName()
        {
            return _gun.GetName() + " + FJM Bullets";
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
            Console.Write("<[FMJ Bullets]>");
        }
    }
}
