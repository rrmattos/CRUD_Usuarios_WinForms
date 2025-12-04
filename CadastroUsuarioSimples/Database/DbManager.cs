using System.Data;

namespace CadastroUsuarioSimples.Database
{
    public class DbManager
    {
        public IDbConnection Connection { get; }

        public DbManager(IDbConnection connection)
        {
            Connection = connection;
        }
    }
}
