using CadastroUsuarioSimples.Database;
using CadastroUsuarioSimples.Utils;
using System;
using System.Windows.Forms;

namespace CadastroUsuarioSimples.Controllers
{
    public class ConnectionController
    {
        private readonly ConnectionDB _db = new ConnectionDB();

        public bool UseMySql(string server, string port, string user, string password, string database)
        {
            try
            {
                if (!_db.TestMySqlConnection(server, port, user, password, database))
                    return false;

                ConnectionFactory.CreateMySql(server, port, user, password, database);

                var conn = ConnectionFactory.GetConnection();

                MigrationService.EnsureUsersTable(conn);

                AppState.Connection = ConnectionFactory.GetConnection();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro UseMySql: " + ex.Message);
                return false;
            }
        }

        public bool UseLocalDatabase()
        {
            try
            {
                if (!_db.CreateOrOpenSQLite())
                    return false;

                ConnectionFactory.CreateSQLite("local_database.db");

                var conn = ConnectionFactory.GetConnection();

                MigrationService.EnsureUsersTable(conn);

                AppState.Connection = conn;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro UseLocalDatabase: " + ex.Message);
                return false;
            }
        }

    }
}
