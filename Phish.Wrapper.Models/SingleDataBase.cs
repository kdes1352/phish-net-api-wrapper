namespace PhishNetApi.Wrapper.Models
{
    using System.Text.Json.Serialization;

    public class SingleDataBase<T> where T : ISingleData
    {
        [JsonPropertyName("error_code")] public int ErrorCode { get; set; }

        [JsonPropertyName("error_message")] public string ErrorMessage { get; set; }

        public SingleResponse<T> Response { get; set; }
    }
}