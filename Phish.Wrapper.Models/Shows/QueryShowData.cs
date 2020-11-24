namespace PhishNetApi.Wrapper.Models.Shows
{
    using Newtonsoft.Json;

    public class QueryShowData : IData
    {
        public int ShowId { get; set; }

        public string ShowDate { get; set; }

        public string ArtistId { get; set; }

        [JsonProperty("billed_as")]
        public string BilledAs { get; set; }

        public string Link { get; set; }

        public string Location { get; set; }

        public string Venue { get; set; }

        public string SetlistNotes { get; set; }

        public int VenueId { get; set; }

        public int TourId { get; set; }

        public string TourName { get; set; }

        [JsonProperty("tour_when")]
        public string TourWhen { get; set; }

        public string ArtistLink { get; set; }
    }
}