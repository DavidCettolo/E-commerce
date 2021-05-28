using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ecommerce_web_app
{
    public class ApiGet<T> : IApiGet<T>
    {
        public async Task<IEnumerable<T>> GetApiAsync(string url)
        {

            var client = new HttpClient();
            var response = await client.GetAsync(url);
            var items = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<T>>(items);
        }

        public async void PostApiAsync(string url,T obj)
        {
            var json = JsonSerializer.Serialize(obj);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var client = new HttpClient();
            await client.PostAsync(url, data);
           
        }
    }
}
