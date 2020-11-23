namespace PhishNetApi.Wrapper.Core.People
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Models;
    using Models.People;

    public class PeopleRequest : Request<People>
    {
        public PeopleRequest(ProjectSettings settings) : base(settings)
        {
            SectionName = "people";
        }

        public async Task<Base<People>> GetAll()
        {
            return await MakeRequest(Constants.MethodNames.All);
        }

        public async Task<PeopleTypes> GetPeopleTypes()
        {
            using var client = Client;
            var response = await client.GetAsync($"{SectionName}/{Constants.MethodNames.Get}?{string.Join("&", Parameters)}");

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var data = await response.Content.ReadAsAsync<PeopleTypes>();

            foreach (var token in data.Response.Data.Descendants())
            {
                var tokenArray = token.ToString().Replace("\"", "").Split(':');
                if (tokenArray.Length < 2)
                {
                    continue;
                }
                data?.Response?.UsableData.Add(new PeopleType {Id = tokenArray[0].Trim(), Name = tokenArray[1].Trim()});
            }

            return data;
        }
    }
}