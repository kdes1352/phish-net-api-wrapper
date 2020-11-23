namespace PhishNetApi.Wrapper.Core.People
{
    using System.Threading.Tasks;
    using Models;
    using Models.People;

    public class AppearanceRequest : Request<Appearance>
    {
        public AppearanceRequest(ProjectSettings settings) : base(settings)
        {
            SectionName = "people";
        }

        public async Task<Base<Appearance>> GetAppearances(int personid, int year = 0)
        {
            AddParameter(nameof(personid), personid);
            if (year >= 1983)
            {
                AddParameter(nameof(year), year);
            }

            return await MakeRequest(Constants.MethodNames.Appearances);
        }
    }
}
