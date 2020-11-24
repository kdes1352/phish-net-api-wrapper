namespace PhishNetApi.Wrapper.Models.Artists
{
    using System.Collections.Generic;
    using Newtonsoft.Json.Linq;

    public class ArtistResponse
    {
        public ArtistResponse()
        {
            UsableData = new List<Artists>();
        }

        public int Count{ get; set; }

        public JObject Data { get; set; }

        public List<Artists>UsableData { get; set; }
    }

    public class Artists
    {
        public int ArtistId { get; set; }

        public string Name { get; set; }

        public string Link { get; set; }
    }
}
