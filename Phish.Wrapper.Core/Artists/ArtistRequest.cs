namespace Phish.Wrapper.Core.Artists
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Models.Artists;

    public class ArtistRequest
    {
        private readonly ProjectSettings Settings;
        private HttpClient _client;

        public ArtistRequest(ProjectSettings settings)
        {
            Settings = settings;
        }

        protected HttpClient Client
        {
            get
            {
                if (_client != null)
                {
                    return _client;
                }

                _client = new HttpClient { BaseAddress = new Uri(Constants.ApiBaseUrl) };
                _client.DefaultRequestHeaders.Accept.Clear();
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                return _client;
            }
        }

        public async Task<ArtistData> GetAllArtists()
        {
            using var client = Client;
            var response = await client.GetAsync($"artists/all?apikey={Settings.ApiKey}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<ArtistData>();
            }

            // TODO: add error handling?
            return null;
        }
    }
}