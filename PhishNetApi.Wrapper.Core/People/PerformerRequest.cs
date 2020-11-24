namespace PhishNetApi.Wrapper.Core.People
{
    using System.Threading.Tasks;
    using Models;
    using Models.People;

    public class PerformerRequest : Request<Performer>
    {
        public PerformerRequest(ProjectSettings settings) : base(settings)
        {
            SectionName = "people";
        }

        public async Task<Base<Performer>> GetPerformersByShow(int showid)
        {
            AddParameter(nameof(showid), showid);
            return await MakeRequest(Constants.MethodNames.ByShow);
        }
    }
}
