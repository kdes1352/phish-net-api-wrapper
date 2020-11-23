namespace PhishNetApi.Wrapper.Models.Artists
{
    using System.Text.Json.Serialization;

    public class ArtistResponse
    {
        public int Count{ get; set; }

        public Artists Data { get; set; }
    }

    public class Artists
    {
        [JsonPropertyName("1")]
        public Artist Phish { get; set; }

        [JsonPropertyName("2")]
        public Artist Trey { get; set; }

        [JsonPropertyName("3")]
        public Artist Mike { get; set; }

        [JsonPropertyName("4")]
        public Artist Fish { get; set; }

        [JsonPropertyName("5")]
        public Artist Page { get; set; }
    }
}
