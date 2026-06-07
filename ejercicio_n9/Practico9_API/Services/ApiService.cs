using System.Text.Json;
using Practico9_API.Models;

namespace Practico9_API.Services
{
    public class ApiService
    {
        private readonly HttpClient _http = new()
        {
            BaseAddress = new Uri("https://jsonplaceholder.typicode.com/")
        };

        public async Task<List<Post>> ObtenerPostsAsync()
        {
            var response = await _http.GetAsync("posts");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<Post>>(json);
            }
            return new List<Post>();
        }

        public async Task<Post?> ObtenerPostPorIdAsync(int id)
        {
            var response = await _http.GetAsync($"posts/{id}");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<Post>(json);
            }
            return null;
        }

        public async Task<List<Usuario>> ObtenerUsuariosAsync()
        {
            var http = new HttpClient();
            var response = await http.GetAsync("https://reqres.in/api/users?page=1");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var resultado = JsonSerializer.Deserialize<RespuestaUsuarios>(json);
                return resultado?.Data ?? new List<Usuario>();
            }
            return new List<Usuario>();
        }
    }
}
