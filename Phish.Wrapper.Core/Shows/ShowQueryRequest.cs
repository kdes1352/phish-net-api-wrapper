namespace PhishNetApi.Wrapper.Core.Shows
{
    using System.Threading.Tasks;
    using Models;
    using Models.Shows;

    public class ShowQueryRequest : Request<QueryShowData>
    {
        public ShowQueryRequest(ProjectSettings settings) : base(settings)
        {
            SectionName = "shows";
        }

        // ReSharper disable InconsistentNaming
        public async Task<Base<QueryShowData>> QueryShows(string showids = "", int year = 0, int month = 0, int day = 0, int venueid = 0, int tourid = 0, string country = "", string city = "", string state = "", string showdate_gt = "", string showdate_gte = "", string showdate_lt = "", string showdate_lte = "", int showyear_gt = 0, int showyear_gte = 0, int showyear_lt = 0, int showyear_lte = 0, int limit = 0, string order = "DESC")
        {
            if (!string.IsNullOrWhiteSpace(showids))
            {
                AddParameter(nameof(showids), showids);
            }

            if (year >= 1983)
            {
                AddParameter(nameof(year), year);
            }

            if (month > 0 && month <= 12)
            {
                AddParameter(nameof(month), month);
            }

            if (day > 0 && day <= 31)
            {
                AddParameter(nameof(day), day);
            }

            if (venueid > 0)
            {
                AddParameter(nameof(venueid), venueid);
            }

            if (tourid > 0)
            {
                AddParameter(nameof(tourid), tourid);
            }

            if (!string.IsNullOrWhiteSpace(country))
            {
                AddParameter(nameof(country), country);
            }

            if (!string.IsNullOrWhiteSpace(city))
            {
                AddParameter(nameof(city), city);
            }

            if (!string.IsNullOrWhiteSpace(state))
            {
                AddParameter(nameof(state), state);
            }

            if (!string.IsNullOrWhiteSpace(showdate_gt))
            {
                AddParameter(nameof(showdate_gt), showdate_gt);
            }

            if (!string.IsNullOrWhiteSpace(showdate_gte))
            {
                AddParameter(nameof(showdate_gte), showdate_gte);
            }

            if (!string.IsNullOrWhiteSpace(showdate_lt))
            {
                AddParameter(nameof(showdate_lt), showdate_lt);
            }

            if (!string.IsNullOrWhiteSpace(showdate_lte))
            {
                AddParameter(nameof(showdate_lte), showdate_lte);
            }

            if (showyear_gt > 0)
            {
                AddParameter(nameof(showyear_gt), showyear_gt);
            }

            if (showyear_gte > 0)
            {
                AddParameter(nameof(showyear_gte), showyear_gte);
            }

            if (showyear_lt > 0)
            {
                AddParameter(nameof(showyear_lt), showyear_lt);
            }

            if (showyear_lte > 0)
            {
                AddParameter(nameof(showyear_lte), showyear_lte);
            }

            if (limit > 0)
            {
                AddParameter(nameof(limit), limit);
            }

            AddParameter(nameof(order), order);

            return await MakeRequest(Constants.MethodNames.Query);
        }
        // ReSharper restore InconsistentNaming
    }
}
