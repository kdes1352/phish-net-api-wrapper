namespace PhishNetApi.Wrapper.Core
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;

    public class RequestBase
    {
        protected ProjectSettings Settings;
        protected List<string> Parameters;
        protected string SectionName;
        private HttpClient _client;

        public RequestBase(ProjectSettings settings)
        {
            Settings = settings;
            Parameters = new List<string> { $"apikey={Settings.ApiKey}" };
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

        protected void AddParameter(string name, object value)
        {
            Parameters.Add($"{name}={value}");
        }
    }
}
