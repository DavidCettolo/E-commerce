using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;

namespace ecommerce_web_app
{
    public class ItemApi:IApiGet<Item>
    {
        public ItemApi() { }

        public IEnumerable<Item> GetApi(string url)
        {
            var request = HttpWebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            var response = request.GetResponse();
            var reader = new StreamReader(response.GetResponseStream());
            var ApiStatus = reader.ReadToEnd();
            return JsonSerializer.Deserialize<List<Item>>(ApiStatus);
        }
    }
}
