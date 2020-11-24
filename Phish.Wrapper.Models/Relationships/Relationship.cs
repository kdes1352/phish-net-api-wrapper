namespace PhishNetApi.Wrapper.Models.Relationships
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Relationship : ISingleData
    {
        public List<Person> Friends { get; set; }

        public List<Person> Fans { get; set; }
    }

    public class Person
    {
        [JsonProperty("uid")]
        public int UserId { get; set; }

        public string Username { get; set; }
    }
}