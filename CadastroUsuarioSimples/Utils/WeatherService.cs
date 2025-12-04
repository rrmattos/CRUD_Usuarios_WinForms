using System.Text.Json;
using System.Threading.Tasks;

namespace CadastroUsuarioSimples.Utils
{
    public class WeatherInfo
    {
        public double Temperature { get; set; }
        public double WindSpeed { get; set; }
        public string Time { get; set; }
    }

    public class WeatherService
    {
        public async Task<WeatherInfo> GetCurrent(double latitude, double longitude)
        {
            string url =
                $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&current_weather=true";

            var resp = await HttpShared.Client.GetStringAsync(url);

            using (var doc = JsonDocument.Parse(resp))
            {
                var current = doc.RootElement
                    .GetProperty("current_weather");

                return new WeatherInfo
                {
                    Temperature = current.GetProperty("temperature").GetDouble(),
                    WindSpeed = current.GetProperty("windspeed").GetDouble(),
                    Time = current.GetProperty("time").GetString()
                };
            }
        }
    }

}
