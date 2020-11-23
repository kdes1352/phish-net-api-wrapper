namespace PhishNetApi.Wrapper.Core.Collections
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Models;
    using Models.Collections;

    public class CollectionRequest : Request<QueryCollection>
    {
        public CollectionRequest(ProjectSettings settings) : base(settings)
        {
            SectionName = "collections";
        }

        public async Task<Base<QueryCollection>> QueryCollections(int collectionid = 0, int uid = 0, string contains = "")
        {
            if (collectionid > 0)
            {
                AddParameter(nameof(collectionid), collectionid);
            }

            if (uid > 0)
            {
                AddParameter(nameof(uid), uid);
            }

            if (!string.IsNullOrWhiteSpace(contains))
            {
                AddParameter(nameof(contains), contains);
            }

            return await MakeRequest(Constants.MethodNames.Query);
        }

        public async Task<GetCollection> Get(int collectionid)
        {
            AddParameter(nameof(collectionid), collectionid);

            using var client = Client;
            var response = await client.GetAsync($"{SectionName}/{Constants.MethodNames.Get}?{string.Join("&", Parameters)}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<GetCollection>();
            }

            return null;
        }
    }
}