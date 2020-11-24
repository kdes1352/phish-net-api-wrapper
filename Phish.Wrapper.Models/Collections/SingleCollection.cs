namespace PhishNetApi.Wrapper.Models.Collections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SingleCollection : ISingleData
    {
        public int CollectionId { get; set; }

        [JsonProperty("uid")] public int UserId { get; set; }

        public string Username { get; set; }

        [JsonProperty("collection_name")] public string CollectionName { get; set; }

        public string Notes { get; set; }

        [JsonProperty("show_count")] public int ShowCount { get; set; }

        public List<CollectionShow> Shows { get; set; }
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