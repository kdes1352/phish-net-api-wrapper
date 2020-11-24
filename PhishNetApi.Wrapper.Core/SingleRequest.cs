namespace PhishNetApi.Wrapper.Core
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Models;

    public class SingleRequest<T> : RequestBase where T : ISingleData
    {
        public SingleRequest(ProjectSettings settings) : base(settings)
        {
        }

        protected async Task<SingleDataBase<T>> MakeRequest(string method)
        {
            using (Client)
            {
                var response = await Client.GetAsync($"{SectionName}/{method}?{string.Join("&", Parameters)}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<SingleDataBase<T>>();
                }

                return null;
            }
        }
    }
}