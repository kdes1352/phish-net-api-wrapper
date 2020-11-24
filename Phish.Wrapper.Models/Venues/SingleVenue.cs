namespace PhishNetApi.Wrapper.Models.Venues
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SingleVenue
    {
        [JsonProperty("error_code")] public int ErrorCode { get; set; }

        [JsonProperty("error_message")] public string ErrorMessage { get; set; }

        public VenueResponse Response { get; set; }
    }

    public class VenueResponse
    {
        public VenueResponse()
        {
            UsableData = new List<Venue>();
        }

        public int Count { get; set; }

        public JObject Data { get; set; }

        public List<Venue>UsableData { get; set; }
    }
}
