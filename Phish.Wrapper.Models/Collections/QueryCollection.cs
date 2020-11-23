namespace PhishNetApi.Wrapper.Models.Collections
{
    using System.Text.Json.Serialization;

    public class QueryCollection : IData
    {
        public int CollectionId { get; set; }

        public string Username { get; set; }

        [JsonPropertyName("uid")]
        public int UserId { get; set; }

        [JsonPropertyName("collection_name")]
        public string Name { get; set; }

        public int Count { get; set; }

        public string Link { get; set; }
    }
}