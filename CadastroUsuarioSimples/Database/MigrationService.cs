using System.Data;

namespace CadastroUsuarioSimples.Database
{
    public static class MigrationService
    {
        public static void EnsureUsersTable(IDbConnection conn)
        {
            bool isMySql = conn.GetType().Name.Contains("MySql");

            string checkSql = isMySql
            ? "SHOW TABLES LIKE 'Users';"
            : "SELECT name FROM sqlite_master WHERE type='table' AND name='Users';";

            string createSql = isMySql
                ? @"CREATE TABLE Users (
                        Id INT AUTO_INCREMENT PRIMARY KEY,
                        Nome VARCHAR(100) NOT NULL,
                        Sobrenome VARCHAR(100),
                        Telefone VARCHAR(50),
                        Email VARCHAR(100),
                        Profissao VARCHAR(100),
                        Endereco VARCHAR(200),
                        DataCadastro DATETIME NOT NULL
                    );"
                : @"CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nome TEXT NOT NULL,
                        Sobrenome TEXT,
                        Telefone TEXT,
                        Email TEXT,
                        Profissao TEXT,
                        Endereco TEXT,
                        DataCadastro TEXT NOT NULL
                    );";

            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = checkSql;
                var result = cmd.ExecuteScalar();

                if (result == null)
                {
                    cmd.CommandText = createSql;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
