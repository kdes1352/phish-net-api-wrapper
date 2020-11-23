namespace PhishNetApi.Wrapper.Models.People
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Newtonsoft.Json.Linq;

    public class PeopleTypes
    {
        [JsonPropertyName("error_code")] public int ErrorCode { get; set; }

        [JsonPropertyName("error_message")] public string ErrorMessage { get; set; }

        public PeopleResponse Response { get; set; }
    }

    public class PeopleResponse
    {
        public PeopleResponse()
        {
            UsableData = new List<PeopleType>();
        }

        public int Count { get; set; }

        public JObject Data { get; set; }

        public List<PeopleType> UsableData { get; set; }
    }

    public class PeopleType
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}