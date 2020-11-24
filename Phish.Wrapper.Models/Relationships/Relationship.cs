namespace PhishNetApi.Wrapper.Models.Relationships
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class RelationshipData : IData
    {

    }

    public class Relationship : ISingleData
    {
        public List<Person> Friends { get; set; }

        public List<Person> Fans { get; set; }
    }

    public class Person
    {
        [JsonPropertyName("uid")] public int UserId { get; set; }

        public string Username { get; set; }
    }
}