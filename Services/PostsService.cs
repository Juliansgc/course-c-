using backend_hector.DTOs;
using System.Formats.Asn1;
using System.Text.Json;

namespace backend_hector.Services
{
    public class PostsService: IPostsService
    {
        private HttpClient _httpClient;
        public PostsService() { 
            _httpClient = new HttpClient();

        }
        public async Task<IEnumerable<PostDTO>> Get() {
            string url = "https://jsonplaceholder.typicode.com/posts";
            var result = await _httpClient.GetAsync(url);
            var body = await result.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var post = JsonSerializer.Deserialize<IEnumerable<PostDTO>>(body, options);
            return post;


        }
    }
}
