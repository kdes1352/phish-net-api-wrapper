namespace PhishNetApi.Wrapper.Models.Reviews
{
    using System.Text.Json.Serialization;

    public class Review : IData
    {
        public int ReviewId { get; set; }

        [JsonPropertyName("posted_date")]
        public string PostedDate { get; set; }

        public string ReviewLink { get; set; }

        [JsonPropertyName("uid")]
        public int UserId { get; set; }

        public string Username { get; set; }

        public string Avatar { get; set; }
        
        [JsonPropertyName("attached_to")]
        public string AttachedTo { get; set; }

        public string Link { get; set; }

        public string Artist { get; set; }

        public int ShowId { get; set; }

        public string ReviewText { get; set; }

        public int Score { get; set; }

        public string Venue { get; set; }

        public string City { get; set; }
        
        public string State { get; set; }

        public string Country { get; set; }
    }
}
