namespace PhishNetApi.Wrapper.Models.Attendance
{
    using Newtonsoft.Json;

    public class Attendance : IData
    {
        [JsonProperty("uid")]
        public int UserId { get; set; }

        public string Username { get; set; }

        public string Profile { get; set; }
    }
}