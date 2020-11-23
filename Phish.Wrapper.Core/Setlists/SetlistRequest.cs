namespace Phish.Wrapper.Core.Setlists
{
    using System.Threading.Tasks;
    using Models;
    using Models.Setlists;

    public class SetlistRequest : RequestBase<Setlist>
    {
        public SetlistRequest(ProjectSettings settings) : base(settings)
        {
            SectionName = "setlists";
        }

        public async Task<Base<Setlist>> GetMostRecent()
        {
            return await MakeRequest("latest");
        }

        public async Task<Base<Setlist>> GetSetlist(string showDate)
        {
            Parameters.Add($"showdate={showDate}");
            return await MakeRequest("get");
        }

        public async Task<Base<Setlist>> GetSetlist(int showid)
        {
            Parameters.Add($"showid={showid}");
            return await MakeRequest("get");
        }

        public async Task<Base<Setlist>> GetRecentSetlists(int limit = 10)
        {
            Parameters.Add($"limit={limit}");
            return await MakeRequest("recent");
        }

        public async Task<Base<Setlist>> GetTodayInPhishHistory()
        {
            return await MakeRequest("tiph");
        }

        public async Task<Base<Setlist>> GetRandomSetlist()
        {
            return await MakeRequest("random");
        }

        public async Task<Base<Setlist>> GetRecentInProgress()
        {
            return await MakeRequest("progress");
        }
    }
}