using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CadastroUsuarioSimples.Utils
{
    public class LocationService
    {
        private readonly HttpClient http = new HttpClient();

        public async Task<(double lat, double lon)> GetLocationAsync()
        {
            try
            {
                var resp = await http.GetStringAsync("https://ipwho.is/");

                using (var doc = JsonDocument.Parse(resp))
                {
                    var root = doc.RootElement;

                    double lat = root.GetProperty("latitude").GetDouble();
                    double lon = root.GetProperty("longitude").GetDouble();

                    return (lat, lon);
                }
            }
            catch
            {
                // Brasília fallback
                return (-15.793889, -47.882778);
            }
        }
    }
}
