using System;

namespace PhishNetApi.Wrapper.App
{
    using System.IO;
    using System.Threading.Tasks;
    using Core;
    using Core.Artists;
    using Core.Attendance;
    using Core.Blog;
    using Core.Authority;
    using Core.Setlists;
    using Microsoft.Extensions.Configuration;
    using Models;
    using Models.Artists;
    using Models.Attendance;
    using Models.Blog;
    using Models.Authority;
    using Models.Setlists;

    class Program
    {
        static void Main(string[] args)
        {
            var settings = GetSettings();

            var request = new SetlistRequest(settings);
            Task<Base<Setlist>> show;
            // Get Most Recent
            // show = request.GetMostRecent();

            // Get Specific Show
            // show = request.GetSetlist(1252698446);

            // Get Recent With Limit
            // show = request.GetRecentSetlists(5);

            // Get TIPH
            // show = request.GetTodayInPhishHistory();

            // GetRandom
            // show = request.GetRandomSetlist();

            // Get Most Recent, Including in progress
            // show = request.GetRecentInProgress();

            var artistsRequest = new ArtistRequest(settings);
            Task<ArtistData> artists;
            // Get All Artists
            artists = artistsRequest.GetAllArtists();
            //Console.WriteLine(artists.Result);

            //Console.WriteLine(show.Result);


            var attendanceRequest = new AttendanceRequest(settings);
            Task<Base<Attendance>> attendance;

            //attendance = attendanceRequest.GetAttendance();
            //attendance = attendanceRequest.GetAttendance("1999-12-07");
            //Console.WriteLine(attendance.Result);


            var blogRequest = new BlogRequest(settings);
            //Task<Base<Blog>> blogs = blogRequest.Get(monthname: "july");
            //Console.WriteLine(blogs.Result);
            var authorizationRequest = new AuthorizationRequest(settings);
            Task<Authorization> authority;

            //authority = authorizationRequest.GetAuthKey();
            //Console.WriteLine(authority.Result);

            Console.ReadKey();
        }

        private static ProjectSettings GetSettings()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true);
            var config = builder.Build();
            return config.GetSection("projectSettings").Get<ProjectSettings>();
        }
    }
}
