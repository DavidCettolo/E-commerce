using System.Text.Json.Serialization;

namespace ecommerce_web_app
{
    public class Item
    {
        [JsonPropertyName("c8")]
        public string C8 { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
    }
}
