using System.Data;

namespace CadastroUsuarioSimples.Utils
{
    public static class AppState
    {
        public static IDbConnection Connection { get; set; }
    }
}
