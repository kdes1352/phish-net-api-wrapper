namespace PhishNetApi.Wrapper.Core.Collections
{
    using System.Threading.Tasks;
    using Models;
    using Models.Collections;

    public class SingleCollectionRequest : SingleRequest<SingleCollection>
    {
        public SingleCollectionRequest(ProjectSettings settings) : base(settings)
        {
            SectionName = "collections";
        }

        public async Task<SingleDataBase<SingleCollection>> Get(int collectionid)
        {
            AddParameter(nameof(collectionid), collectionid);
            return await MakeRequest(Constants.MethodNames.Get);
        }
    }
}