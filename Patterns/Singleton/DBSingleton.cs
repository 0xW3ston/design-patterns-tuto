namespace syntaxApp.patterns.Singleton
{
    public class DBSingleton
    {
        private static DBSingleton? _dbinstance;
        private MySQLConnector _connector;
        private DBSingleton() {
            // Database Initialization...
            _connector = new MySQLConnector(
                    "localhost",
                    "3306",
                    "root",
                    "12345678"
                );
        }

        public static DBSingleton GetInstance()
        {
            if (_dbinstance == null)
                _dbinstance = new DBSingleton();
            return _dbinstance;
        }

        public MySQLConnector GetConnexion()
        {
            return _connector;
        }
    }
}