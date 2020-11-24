namespace PhishNetApi.Wrapper.Core
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Models;

    public class Request<T>:RequestBase where T : IData
    {
        public Request(ProjectSettings settings) : base(settings)
        {
        }

        protected async Task<Base<T>> MakeRequest(string method)
        {
            using (Client)
            {
                var response = await Client.GetAsync($"{SectionName}/{method}?{string.Join("&", Parameters)}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<Base<T>>();
                }

                // TODO: add error handling?
                return null;
            }
        }
    }
}
