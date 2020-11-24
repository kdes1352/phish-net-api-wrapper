namespace PhishNetApi.Wrapper.Models
{
    using Newtonsoft.Json;

    public class Base<T> where T : IData
    {
        [JsonProperty("error_code")] public int ErrorCode { get; set; }

        [JsonProperty("error_message")] public string ErrorMessage { get; set; }

        public Response<T> Response { get; set; }
    }
}