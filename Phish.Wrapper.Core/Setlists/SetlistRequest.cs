namespace PhishNetApi.Wrapper.Core.Setlists
{
    using System.Threading.Tasks;
    using Models;
    using Models.Setlists;

    public class SetlistRequest : Request<Setlist>
    {
        public SetlistRequest(ProjectSettings settings) : base(settings)
        {
            SectionName = "setlists";
        }

        public async Task<Base<Setlist>> GetMostRecent()
        {
            return await MakeRequest("latest");
        }

        public async Task<Base<Setlist>> GetSetlist(string showdate)
        {
            AddParameter(nameof(showdate), showdate);
            return await MakeRequest(Constants.MethodNames.Get);
        }

        public async Task<Base<Setlist>> GetSetlist(int showid)
        {
            AddParameter(nameof(showid), showid);
            return await MakeRequest(Constants.MethodNames.Get);
        }

        public async Task<Base<Setlist>> GetRecentSetlists(int limit = 10)
        {
            AddParameter(nameof(limit), limit);
            return await MakeRequest(Constants.MethodNames.Recent);
        }

        public async Task<Base<Setlist>> GetTodayInPhishHistory()
        {
            return await MakeRequest(Constants.MethodNames.Tiph);
        }

        public async Task<Base<Setlist>> GetRandomSetlist()
        {
            return await MakeRequest(Constants.MethodNames.Random);
        }

        public async Task<Base<Setlist>> GetRecentInProgress()
        {
            return await MakeRequest(Constants.MethodNames.Progress);
        }
    }
}