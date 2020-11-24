namespace PhishNetApi.Wrapper.Core.Venues
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Models;
    using Models.Venues;
    using Newtonsoft.Json;

    public class VenueRequest : SingleRequest<Venue>
    {
        public VenueRequest(ProjectSettings settings) : base(settings)
        {
            SectionName = "venues";
        }

        public async Task<SingleDataBase<Venue>> Get(int venueid)
        {
            AddParameter(nameof(venueid), venueid);
            return await MakeRequest(Constants.MethodNames.Get);
        }

        public async Task<SingleVenue> GetAll()
        {
            using var client = Client;
            var response = await client.GetAsync($"{SectionName}/{Constants.MethodNames.All}?{string.Join("&", Parameters)}");

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var data = await response.Content.ReadAsAsync<SingleVenue>();
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
                    var venue = JsonConvert.DeserializeObject<Venue>(jsonString);
                    data.Response?.UsableData.Add(venue);
                }
                catch
                {
                    counter++;
                    continue;
                }

                counter++;
            }

            return data;
        }
    }
}