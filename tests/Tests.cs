using syntaxApp.patterns.Singleton;
using syntaxApp.Patterns.Decorator;
using syntaxApp.Patterns.Strategy;
using syntaxApp.Patterns.Observer;
using syntaxApp.Patterns.Factory;
using syntaxApp.Patterns.Facade;
using syntaxApp.Patterns.Adapter;
using syntaxApp.Patterns.Proxy;

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

        public static void TestObserver()
        {
            var notificationSubject = new NotificationSubject();

            UserObserver user1 = new UserObserver();
            UserObserver user2 = new UserObserver();

            notificationSubject.AddObserver(user1);
            notificationSubject.AddObserver(user2);

            notificationSubject.setNewMsg("Hello All");
        }

        public static void TestFactory()
        {
            IVehicleFactory carFactory = new CarFactory();
            IVehicleFactory planeFactory = new PlaneFactory();

            IVehicle newCar = carFactory.CreateVehicle();
            IVehicle newPlane = planeFactory.CreateVehicle();

            newCar.printVehiculeDescription();
            newPlane.printVehiculeDescription();

        }

        public static void TestFacade()
        {
            HomeAutomationFacade homeSystem = new HomeAutomationFacade();

            homeSystem.EnterHome();

            homeSystem.LeaveHome();
        }

        public static void TestAdapter()
        {
            LegacyLogger legacyLogger = new LegacyLogger();

            LegacyLoggerAdapter logger = new LegacyLoggerAdapter(legacyLogger);

            logger.LogInfo("Gran Turismo 4 Arcade theme is goated");

            logger.LogInfo("Mary Poppins");

            logger.LogError("Evil Knievel");
        }

        public static void TestProxy()
        {
            ProxyImage image = new ProxyImage("/c/Users/user1/documents/lol.png");

            image.Display();
        }
    }
}
