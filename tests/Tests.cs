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

        
    }
}
