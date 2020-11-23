﻿namespace PhishNetApi.Wrapper.Core
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Models;

    public class Request<T> where T : IData
    {
        protected ProjectSettings Settings;
        protected List<string> Parameters;
        protected string SectionName;
        private HttpClient _client;

        public Request()
        {
            Parameters = new List<string> { $"apikey={Settings.ApiKey}" };
        }

        public Request(ProjectSettings settings)
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

        protected async Task<Base<T>> MakeRequest(string method)
        {
            using var client = Client;
            var response = await client.GetAsync($"{SectionName}/{method}?{string.Join("&", Parameters)}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Base<T>>();
            }

            // TODO: add error handling?
            return null;
        }

        protected void AddParameter(string name, object value)
        {
            Parameters.Add($"{name}={value}");
        }
    }
}