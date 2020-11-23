namespace PhishNetApi.Wrapper.Core.Authority
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using Core;
    using Models.Authority;
    using Newtonsoft.Json;

    public class AuthorizationRequest
    {
        private readonly ProjectSettings Settings;
        private HttpClient _client;

        public AuthorizationRequest(ProjectSettings settings)
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

                _client = new HttpClient {BaseAddress = new Uri(Constants.ApiBaseUrl)};
                _client.DefaultRequestHeaders.Accept.Clear();
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                return _client;
            }
        }

        public async Task<Authorization> GetAuthKey()
        {
            using var client = Client;
            //var response = await client.GetAsync($"authority/get?apikey={Settings.ApiKey}&uid={Settings.UserId}&unique_hash={GetUniqueHash()}");
            var payload = new {apikey = Settings.ApiKey, uid = Settings.UserId, unique_hash = Settings.UniqueHash};
            var json = JsonConvert.SerializeObject(payload);
            var data = new StringContent(json, Encoding.ASCII, "application/json");
            //var pairs = new List<KeyValuePair<string, string>> {new KeyValuePair<string, string>("apikey", Settings.ApiKey), new KeyValuePair<string, string>("uid", Settings.UserId.ToString()), new KeyValuePair<string, string>("unique_hash", Settings.UniqueHash)};
            //var content = new FormUrlEncodedContent(pairs);
            var response = await client.PostAsync($"{Constants.ApiBaseUrl}authority/get", data);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Authorization>();
            }

            // TODO: add error handling?
            return null;
        }
    }
}