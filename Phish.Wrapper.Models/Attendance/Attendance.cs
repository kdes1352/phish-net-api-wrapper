namespace Phish.Wrapper.Models.Attendance
{
    using System.Text.Json.Serialization;

    public class Attendance : IData
    {
        [JsonPropertyName("uid")]
        public int UserId { get; set; }

        public string Username { get; set; }

        public string Profile { get; set; }
    }
}