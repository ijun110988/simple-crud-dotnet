using System.Text.Json.Serialization;

public class Product
{
    public int Id { get; set; }

    [JsonPropertyName("namaProduk")]
    public required string Name { get; set; }

    [JsonPropertyName("harga")]
    public decimal Price { get; set; }
}
