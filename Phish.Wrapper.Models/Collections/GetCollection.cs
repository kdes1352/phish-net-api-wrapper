namespace PhishNetApi.Wrapper.Models.Collections
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class GetCollection
    {
        [JsonPropertyName("error_code")] public int ErrorCode { get; set; }

        [JsonPropertyName("error_message")] public string ErrorMessage { get; set; }

        public CollectionResponse Response { get; set; }
    }

    public class CollectionResponse
    {
        public int Count { get; set; }

        public InvdividualCollection Data { get; set; }
    }

    public class InvdividualCollection
    {
        public int CollectionId { get; set; }

        [JsonPropertyName("uid")]
        public int UserId { get; set; }

        public string Username { get; set; }

        [JsonPropertyName("collection_name")]
        public string CollectionName { get; set; }

        public string Notes { get; set; }

        [JsonPropertyName("show_count")]
        public int ShowCount { get; set; }

        public List<CollectionShow>Shows { get; set; }
    }

    public class CollectionShow
    {
        public string ShowId { get; set; }

        public string ShowDate { get; set; }

        public string Link { get; set; }

        public string Venue { get; set; }

        public string Location { get; set; }
    }
}