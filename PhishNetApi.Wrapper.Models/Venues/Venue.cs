namespace PhishNetApi.Wrapper.Models.Venues
{
    using Newtonsoft.Json;

    public class Venue : ISingleData
    {
        public int VenueId { get; set; }

        [JsonProperty("venue")]
        public string VenueName { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Link { get; set; }

        [JsonProperty("alias_of_venueid")]
        public int AliasOfVenueId { get; set; }

        [JsonProperty("alias_of_venue")]
        public string AliasOfVenue { get; set; }

        [JsonProperty("alias_of_link")]
        public string AliasOfLink { get; set; }
    }
}
