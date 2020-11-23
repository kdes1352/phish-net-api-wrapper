namespace PhishNetApi.Wrapper.Models.JamCharts
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SingleJamChart
    {
        [JsonPropertyName("error_code")] public int ErrorCode { get; set; }

        [JsonPropertyName("error_message")] public string ErrorMessage { get; set; }

        public JamChartResponse Response { get; set; }
    }

    public class JamChartResponse
    {
        public int Count { get; set; }

        public JamChartData Data { get; set; }
    }

    public class JamChartData
    {
        public int SongId { get; set; }

        public string Song { get; set; }

        public string Link { get; set; }

        public List<JamChartEntry>Entries { get; set; }
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
