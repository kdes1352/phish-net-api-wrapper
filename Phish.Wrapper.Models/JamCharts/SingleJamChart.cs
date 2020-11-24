namespace PhishNetApi.Wrapper.Models.JamCharts
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

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

        [JsonProperty("marked_recommended")]
        public int Recommended { get; set; }

        [JsonProperty("marked_startswith")]
        public int StartsWith { get; set; }
    }
}