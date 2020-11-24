namespace PhishNetApi.Wrapper.Models
{
    using Newtonsoft.Json;

    public class SingleDataBase<T> where T : ISingleData
    {
        [JsonProperty("error_code")] public int ErrorCode { get; set; }

        [JsonProperty("error_message")] public string ErrorMessage { get; set; }

        public SingleResponse<T> Response { get; set; }
    }
}