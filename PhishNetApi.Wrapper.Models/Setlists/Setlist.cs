namespace PhishNetApi.Wrapper.Models.Setlists
{
    using Newtonsoft.Json;

    public class Setlist : IData
    {
        public int ShowId { get; set; }

        public string ShowDate { get; set; }

        [JsonProperty("short_date")] public string ShortDate { get; set; }

        [JsonProperty("long_date")] public string LongDate { get; set; }

        [JsonProperty("relative_date")] public string RelativeDate { get; set; }

        public string Url { get; set; }

        public string GapChart { get; set; }

        public string Artist { get; set; }

        public int ArtistId { get; set; }

        public int VenueId { get; set; }

        public string Venue { get; set; }

        public string Location { get; set; }

        public string SetlistData { get; set; }

        public string SetlistNotes { get; set; }

        public string Rating { get; set; }
    }
}