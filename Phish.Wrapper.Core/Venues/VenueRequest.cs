namespace PhishNetApi.Wrapper.Core.Venues
{
    using System.Threading.Tasks;
    using Models;
    using Models.Venues;

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
    }
}