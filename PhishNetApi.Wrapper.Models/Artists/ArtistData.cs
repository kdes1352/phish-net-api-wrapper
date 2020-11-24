namespace PhishNetApi.Wrapper.Models.Artists
{
    using Newtonsoft.Json;

    public class ArtistData
    {
        [JsonProperty("error_code")] public int ErrorCode { get; set; }

        [JsonProperty("error_message")] public string ErrorMessage { get; set; }

        public ArtistResponse Response { get; set; }
    }
}
