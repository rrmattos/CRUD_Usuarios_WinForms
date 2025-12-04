using System;
using System.Data.SQLite;
using System.IO;

namespace CadastroUsuarioSimples.Database
{
    public class ConnectionDB
    {
        private string sqlitePath = "local_database.db";

        public bool TestMySqlConnection(string server, string port, string user, string password, string database)
        {
            string connStr = $"server={server};port={port};user={user};password={password};database={database}";

            try
            {
                using (var conn = new MySql.Data.MySqlClient.MySqlConnection(connStr))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        public bool CreateOrOpenSQLite()
        {
            try
            {
                if (!File.Exists(sqlitePath))
                {
                    SQLiteConnection.CreateFile(sqlitePath);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
