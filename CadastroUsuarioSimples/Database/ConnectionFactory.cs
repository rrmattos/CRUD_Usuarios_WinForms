using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SQLite;

namespace CadastroUsuarioSimples.Database
{
    public static class ConnectionFactory
    {
        private static IDbConnection _connection;

        public static IDbConnection GetConnection()
        {
            return _connection;
        }

        public static void CreateMySql(string server, string port, string user, string password, string database)
        {
            string connStr =
                $"Server={server};Port={port};Uid={user};Pwd={password};Database={database};";

            _connection = new MySqlConnection(connStr);
            _connection.Open();
        }

        public static void CreateSQLite(string file)
        {
            string connStr = $"Data Source={file}";
            _connection = new SQLiteConnection(connStr);
            _connection.Open();
        }
    }
}
