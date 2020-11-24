namespace PhishNetApi.Wrapper.Models.Blog
{
    using Newtonsoft.Json;

    public class Blog : IData
    {
        [JsonProperty("pubdate")]
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
