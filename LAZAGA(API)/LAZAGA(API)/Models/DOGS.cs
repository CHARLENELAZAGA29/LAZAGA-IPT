using System.Text.Json.Serialization;

namespace LAZAGA_API_.Models

{
    public class DogAPI
    {
        [JsonPropertyName("message")]

        public string Message { get; set; } = "";

        [JsonPropertyName("status")]

        public string Status { get; set; } = "";
    }
}
