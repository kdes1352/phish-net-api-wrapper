namespace PhishNetApi.Wrapper.Core.Blog
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models;
    using Models.Blog;

    public class BlogRequest : RequestBase<Blog>
    {
        private readonly List<string> _monthNames = new List<string>
        {
            "january",
            "february",
            "march",
            "april",
            "may",
            "june",
            "july",
            "august",
            "september",
            "october",
            "november",
            "december"
        };

        public BlogRequest(ProjectSettings settings) : base(settings)
        {
            SectionName = "blog";
        }

        public async Task<Base<Blog>> Get(int month = 0, int day = 0, string username = "", int author = 0, string monthname = "", int year = 0)
        {
            if (month > 0 && month < 13)
            {
                AddParameter(nameof(month), month);
            }

            if (day > 0 && day < 32)
            {
                AddParameter(nameof(day), day);
            }

            if (!string.IsNullOrWhiteSpace(username))
            {
                AddParameter(nameof(username), username);
            }

            if (author > 0)
            {
                AddParameter(nameof(author), author);
            }

            if (_monthNames.Contains(monthname.ToLower()))
            {
                AddParameter(nameof(monthname), monthname);
            }

            if (year >= 2009)
            {
                AddParameter(nameof(year), year);
            }

            return await MakeRequest(Constants.MethodNames.Get);

        }
    }
}