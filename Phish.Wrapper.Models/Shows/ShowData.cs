namespace PhishNetApi.Wrapper.Models.Shows
{
    public class ShowData : IData
    {
        public string Artist { get; set; }

        public int ArtistId { get; set; }

        public int ShowId { get; set; }

        public string ShowDate { get; set; }

        public string Link { get; set; }

        public string Venue { get; set; }

        public int VenueId { get; set; }

        public string Location { get; set; }
    }
}
