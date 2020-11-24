namespace PhishNetApi.Wrapper.Models.Collections
{
    using Newtonsoft.Json;

    public class QueryCollection : IData
    {
        public int CollectionId { get; set; }

        public string Username { get; set; }

        [JsonProperty("uid")]
        public int UserId { get; set; }

        [JsonProperty("collection_name")]
        public string Name { get; set; }

        public int Count { get; set; }

        public string Link { get; set; }
    }
}