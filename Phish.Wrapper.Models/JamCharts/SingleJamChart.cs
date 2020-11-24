namespace PhishNetApi.Wrapper.Models.JamCharts
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SingleJamChart : ISingleData
    {
        public int SongId { get; set; }

        public string Song { get; set; }

        public string Link { get; set; }

        public List<JamChartEntry> Entries { get; set; }
    }

    public class JamChartEntry
    {
        public string ShowDate { get; set; }

        public int ShowId { get; set; }

        public string Link { get; set; }

        public string Set { get; set; }

        [JsonPropertyName("marked_recommended")]
        public int Recommended { get; set; }

        [JsonPropertyName("marked_startswith")]
        public int StartsWith { get; set; }
    }
}