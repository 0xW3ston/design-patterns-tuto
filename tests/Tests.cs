using syntaxApp.patterns.Singleton;
using syntaxApp.Patterns.Decorator;
using syntaxApp.Patterns.Strategy;
using syntaxApp.Patterns.Observer;
using syntaxApp.Patterns.Factory;
using syntaxApp.Patterns.Facade;
using syntaxApp.Patterns.Adapter;


namespace syntaxApp.tests
{
    public static class Tests
    {
        public static void TestSingleton()
        {
            int rowsAffected = DBSingleton.GetInstance()
            .GetConnexion()
            .executeSQL("SELECT * FROM User WHERE name = \"test\"");


            Console.Write($"Rows affected: \u001b[31m{rowsAffected}\u001b[0m\n");
        }

        public static void TestDecorator()
        {
            IGun defaultGun = new BaseGun("M16");

            IGun upgradedGun = new HolographicSightDecorator(defaultGun);

            upgradedGun = new SilencerDecorator(upgradedGun);

            upgradedGun = new ExtendedMagazineDecorator(upgradedGun);

            upgradedGun = new FMJ_BulletDecorator(upgradedGun);

            upgradedGun.AimDown();
            upgradedGun.Shoot();
            upgradedGun.Reload();

            Console.WriteLine(upgradedGun.GetName());
        }

        public static void TestStrategy()
        {
            // Using Strategy 1: FedEx Shipping

            IShippingStrategy FedEx = new FedExShipping();

            ShippingService shipService = new ShippingService(50.25, FedEx);

            Console.WriteLine($"[Using FedEx] <Cost> -> [{shipService.CalculateShippingCosts(100)}]");

            // Using Strategy 2: DHL Shipping

            IShippingStrategy Dhl = new DHLShipping();

            shipService.SetShippingStrategy(Dhl);

            Console.WriteLine($"[Using Dhl] <Cost> -> [{shipService.CalculateShippingCosts(100)}]");
        }
    }
}
