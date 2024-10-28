namespace syntaxApp.patterns.Singleton
{
    public class MySQLConnector
    {
        private string _host;
        private string _port;
        private string _username;
        private string _password;

        public MySQLConnector(string host, string port, string username, string password)
        {
            _host = host;
            _port = port;
            _username = username;
            _password = password;

            connect();
        }
        public string getHost()
        {
            return _host;
        }

        private void connect()
        {
            // Setting up connexion to the database
        }

        private void disconnect()
        {
            // Disconnecting from the database
        }

        public int executeSQL(string sql_query)
        {
            // Execute a query and wait for the number of "affected rows"
            Console.WriteLine($"Executing query: <{sql_query}>");
            return 1;
        }

        ~MySQLConnector()
        {
            Console.WriteLine("Object is being finalized and removed.");
            disconnect();
            // Code to disconnect from the database.
        }
    }
}
