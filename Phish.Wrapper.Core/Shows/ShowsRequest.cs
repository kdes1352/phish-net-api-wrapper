namespace PhishNetApi.Wrapper.Core.Shows
{
    using System.Threading.Tasks;
    using Models;
    using Models.Shows;

    public class ShowLinksRequest : Request<ShowLinks>
    {
        public ShowLinksRequest(ProjectSettings settings) : base(settings)
        {
            SectionName = "shows";
        }

        public async Task<Base<ShowLinks>> GetShowLinks(int showid)
        {
            if (showid > 0)
            {
                AddParameter(nameof(showid), showid);
            }

            return await MakeRequest(Constants.MethodNames.Links);
        }
    }
}
