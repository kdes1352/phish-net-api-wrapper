namespace PhishNetApi.Wrapper.Models
{
    using System.Text.Json.Serialization;

    public class Base<T> where T : IData
    {
        [JsonPropertyName("error_code")] public int ErrorCode { get; set; }

        [JsonPropertyName("error_message")] public string ErrorMessage { get; set; }

        public Response<T> Response { get; set; }
    }
}