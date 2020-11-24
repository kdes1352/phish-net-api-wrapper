namespace PhishNetApi.Wrapper.Core.Relationships
{
    using System.Threading.Tasks;
    using Models;
    using Models.Relationships;

    public class RelationshipRequest : SingleRequest<Relationship>
    {
        public RelationshipRequest(ProjectSettings settings) : base(settings)
        {
            SectionName = "relationships";
        }

        public async Task<SingleDataBase<Relationship>> Get(int uid)
        {
            AddParameter(nameof(uid), uid);
            return await MakeRequest(Constants.MethodNames.Get);
        }
    }
}