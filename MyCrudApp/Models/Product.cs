using System.Text.Json.Serialization;

namespace MyCrudApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [JsonPropertyName("namaProduk")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("harga")]
        public decimal Price { get; set; }
    }
}
