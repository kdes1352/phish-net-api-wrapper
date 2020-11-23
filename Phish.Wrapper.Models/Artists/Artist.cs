namespace Phish.Wrapper.Models.Artists
{
    using System.Text.Json.Serialization;

    public class Artist
    {
        public int ArtistId { get; set; }

        public string Name { get; set; }

        public string Link { get; set; }
    }
}
