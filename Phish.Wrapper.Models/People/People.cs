namespace PhishNetApi.Wrapper.Models.People
{
    public class People : IData
    {
        public int PersonId { get; set; }

        public string Name { get; set; }

        public string Link { get; set; }

        public string PeopleType { get; set; }
    }
}
