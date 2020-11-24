namespace PhishNetApi.Wrapper.Models.Shows
{
    // ReSharper disable InconsistentNaming
    public class QueryShowData : IData
    {
        public int ShowId { get; set; }

        public string ShowDate { get; set; }

        public string ArtistId { get; set; }

        public string Billed_As { get; set; }

        public string Link { get; set; }

        public string Location { get; set; }

        public string Venue { get; set; }

        public string SetlistNotes { get; set; }

        public int VenueId { get; set; }

        public int TourId { get; set; }

        public string TourName { get; set; }

        public string Tour_When { get; set; }

        public string ArtistLink { get; set; }
    }
    // ReSharper restore InconsistentNaming
}