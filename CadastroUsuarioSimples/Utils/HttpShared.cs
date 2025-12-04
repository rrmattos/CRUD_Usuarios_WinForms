using System.Net.Http;

namespace CadastroUsuarioSimples.Utils
{
    public static class HttpShared
    {
        public static readonly HttpClient Client = new HttpClient();
    }
}
