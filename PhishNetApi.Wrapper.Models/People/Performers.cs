namespace PhishNetApi.Wrapper.Models.People
{
    public class Performer : IData
    {
        public int ShowId { get; set; }

        public string ShowDate { get; set; }

        public int PersonId { get; set; }

        public string Role { get; set; }

        public string Footnote { get; set; }

        public string Name { get; set; }

        public string Link { get; set; }
    }
}
