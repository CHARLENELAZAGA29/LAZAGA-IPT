using System.Text.Json.Serialization;

namespace API_LAZAGA.Models
{
    public class DogAPI
{
    [JsonPropertyName("message")]

    public string Message { get; set; } = "";

    [JsonPropertyName("status")]

    public string Status { get; set; } = "";
}
}
