namespace PhishNetApi.Wrapper.Core.Reviews
{
    using System.Threading.Tasks;
    using Models;
    using Models.Reviews;

    public class ReviewRequest : Request<Review>
    {
        public ReviewRequest(ProjectSettings settings) : base(settings)
        {
            SectionName = "reviews";
        }

        // ReSharper disable InconsistentNaming
        public async Task<Base<Review>> QueryReviews(int showid = 0, int uid = 0, string posted_on = "", string posted_after = "", string posted_before = "")
        {
            if (showid > 0)
            {
                AddParameter(nameof(showid), showid);
            }

            if (uid > 0)
            {
                AddParameter(nameof(uid), uid);
            }

            if (!string.IsNullOrWhiteSpace(posted_on))
            {
                AddParameter(nameof(posted_on), posted_on);
            }

            if (!string.IsNullOrWhiteSpace(posted_after))
            {
                AddParameter(nameof(posted_after), posted_after);
            }

            if (!string.IsNullOrWhiteSpace(posted_before))
            {
                AddParameter(nameof(posted_before), posted_before);
            }

            return await MakeRequest(Constants.MethodNames.Query);
        }
        // ReSharper restore InconsistentNaming
    }
}