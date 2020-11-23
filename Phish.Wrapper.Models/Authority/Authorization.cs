namespace PhishNetApi.Wrapper.Models.Authority
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Authorization
    {
        [JsonPropertyName("error_code")] public int ErrorCode { get; set; }

        [JsonPropertyName("error_message")] public string ErrorMessage { get; set; }

        public AuthResponse Response { get; set; }
    }

    public class AuthResponse
    {
        public int Count { get; set; }
        public List<AuthData> Data { get; set; }
    }

    public class AuthData
    {
        [JsonPropertyName("uid")]
        public int UserId { get; set; }

        public int AppId { get; set; }

        public string AuthKey { get; set; }
    }
}
