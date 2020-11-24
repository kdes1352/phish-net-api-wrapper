namespace PhishNetApi.Wrapper.Models.Relationships
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Relationship : ISingleData
    {
        public List<Person> Friends { get; set; }

        public List<Person> Fans { get; set; }
    }

    public class Person
    {
        // ReSharper disable once InconsistentNaming
        public int uid { get; set; }

        public string Username { get; set; }
    }
}