namespace PhishNetApi.Wrapper.Core.JamCharts
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Models;
    using Models.JamCharts;

    public class JamChartRequest : Request<JamChart>
    {
        public JamChartRequest(ProjectSettings settings) : base(settings)
        {
            SectionName = "jamcharts";
        }

        public async Task<Base<JamChart>> GetAll()
        {
            return await MakeRequest(Constants.MethodNames.All);
        }

        public async Task<SingleJamChart> GetSingle(string songid)
        {
            AddParameter(nameof(songid), songid);

            using var client = Client;
            var response = await client.GetAsync($"{SectionName}/{Constants.MethodNames.Get}?{string.Join("&", Parameters)}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SingleJamChart>();
            }

            return null;
        }
    }
}