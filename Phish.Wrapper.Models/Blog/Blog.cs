namespace Phish.Wrapper.Models.Blog
{
    using System.Text.Json.Serialization;

    public class Blog : IData
    {
        [JsonPropertyName("pubdate")]
        public string PublishDate { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public string Teaser { get; set; }

        public string Author { get; set; }

        public string Profile { get; set; }

        public string Category { get; set; }

        public string ShortUrl { get; set; }

        public string Attachment { get; set; }
    }
}
