namespace Phish.Wrapper.Models.Setlists
{
    using System.Text.Json.Serialization;

    public class SetlistResponse : IData
    {
        public int ShowId { get; set; }

        public string ShowDate { get; set; }

        [JsonPropertyName("short_date")] public string ShortDate { get; set; }

        [JsonPropertyName("long_date")] public string LongDate { get; set; }

        [JsonPropertyName("relative_date")] public string RelativeDate { get; set; }

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