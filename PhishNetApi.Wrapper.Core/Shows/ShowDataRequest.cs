namespace PhishNetApi.Wrapper.Core.Shows
{
    using System.Threading.Tasks;
    using Models;
    using Models.Shows;

    public class ShowDataRequest : Request<ShowData>
    {
        public ShowDataRequest(ProjectSettings settings) : base(settings)
        {
            SectionName = "shows";
        }

        public async Task<Base<ShowData>> GetUpcomingShows()
        {
            return await MakeRequest(Constants.MethodNames.Upcoming);
        }
    }
}
