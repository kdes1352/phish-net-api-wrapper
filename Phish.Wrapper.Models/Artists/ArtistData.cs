namespace PhishNetApi.Wrapper.Models.Artists
{
    using System.Text.Json.Serialization;

    public class ArtistData
    {
        [JsonPropertyName("error_code")] public int ErrorCode { get; set; }

        [JsonPropertyName("error_message")] public string ErrorMessage { get; set; }

        public ArtistResponse Response { get; set; }
    }
}
