using CadastroUsuarioSimples.Database;
using CadastroUsuarioSimples.Models;
using System;
using System.Data;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CadastroUsuarioSimples.Controllers
{
    public class UserController
    {
        private readonly UserRepository _repo;

        public UserController()
        {
            _repo = new UserRepository();
        }

        public PageResult<User> SearchUsers(string filter, int page, int pageSize)
        {
            return _repo.Search(filter, page, pageSize);
        }

        public Task<User> GetById(int id)
        {
            return _repo.GetById(id);
        }

        public async Task<bool> Save(User user)
        {
            if (user.Id == 0)
                return await _repo.Insert(user);
            else
                return await _repo.Update(user);
        }

        public Task<bool> Delete(int id)
        {
            return _repo.Delete(id);
        }

        public async Task<DateTime> GetCurrentDateTime()
        {
            try
            {
                using (var http = new HttpClient())
                {
                    string url = "http://worldtimeapi.org/api/timezone/America/Sao_Paulo";

                    string json = await http.GetStringAsync(url);

                    var doc = JsonDocument.Parse(json);
                    string dateString = doc.RootElement.GetProperty("datetime").GetString();

                    return DateTime.Parse(dateString);
                }
            }
            catch
            {
                return DateTime.Now;
            }
        }
    }
}
