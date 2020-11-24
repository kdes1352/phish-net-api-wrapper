namespace PhishNetApi.Wrapper.Core.Artists
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Models.Artists;
    using Newtonsoft.Json;

    public class ArtistRequest
    {
        private readonly ProjectSettings _settings;
        private HttpClient _client;

        public ArtistRequest(ProjectSettings settings)
        {
            _settings = settings;
        }

        protected HttpClient Client
        {
            get
            {
                if (_client != null)
                {
                    return _client;
                }

                _client = new HttpClient { BaseAddress = new Uri("https://api.phish.net/v3/") };
                _client.DefaultRequestHeaders.Accept.Clear();
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                return _client;
            }
        }

        public async Task<ArtistData> GetAllArtists()
        {
            using (Client)
            {
                var response = await Client.GetAsync($"artists/all?apikey={_settings.ApiKey}");

                if (!response.IsSuccessStatusCode)
                {
                    // TODO: add error handling?
                    return null;
                }

                var data = await response.Content.ReadAsAsync<ArtistData>();
                var counter = 1;
                foreach (var token in data.Response.Data.Descendants())
                {
                    var jsonString = token.ToString();
                    if (counter == 1)
                    {
                        jsonString = jsonString.Remove(0, 5);
                    }

                    try
                    {
                        var artist = JsonConvert.DeserializeObject<Artists>(jsonString);

                        data.Response?.UsableData.Add(artist);
                    }
                    catch
                    {
                        //empty
                    }

                    counter++;
                }

                return data;
            }
        }
    }
}