namespace PhishNetApi.Wrapper.Core.Relationships
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Models;
    using Models.Relationships;

    public class RelationshipRequest : Request<RelationshipData>
    {
        public RelationshipRequest(ProjectSettings settings) : base(settings)
        {
            SectionName = "relationships";
        }

        public async Task<SingleDataBase<Relationship>> Get(int uid)
        {
            AddParameter(nameof(uid), uid);

            using var client = Client;
            var response = await client.GetAsync($"{SectionName}/{Constants.MethodNames.Get}?{string.Join("&", Parameters)}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SingleDataBase<Relationship>>();
            }

            return null;
        }
    }
}