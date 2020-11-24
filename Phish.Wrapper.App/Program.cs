using System;

namespace PhishNetApi.Wrapper.App
{
    using System.IO;
    using System.Threading.Tasks;
    using Core;
    using Core.Artists;
    using Core.Attendance;
    using Core.Blog;
    using Core.Collections;
    using Core.JamCharts;
    using Core.People;
    using Core.Setlists;
    using Core.Venues;
    using Microsoft.Extensions.Configuration;
    using Models;
    using Models.Artists;
    using Models.Attendance;
    using Models.Blog;
    using Models.Collections;
    using Models.Setlists;

    class Program
    {
        static void Main(string[] args)
        {
            var settings = GetSettings();

            var request = new SetlistRequest(settings);
            Task<Base<Setlist>> show;
            // Get Most Recent
            //show = request.GetMostRecent();
            //Console.WriteLine(show.Result);

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
            //artists = artistsRequest.GetAllArtists();
            //Console.WriteLine(artists.Result);

            //Console.WriteLine(show.Result);


            var attendanceRequest = new AttendanceRequest(settings);
            Task<Base<Attendance>> attendance;

            //attendance = attendanceRequest.GetAttendance();
            attendance = attendanceRequest.GetAttendance("1999-12-07");
            //Console.WriteLine(attendance.Result);


            var blogRequest = new BlogRequest(settings);
            Task<Base<Blog>> blogs;

            //blogs = blogRequest.Get(monthname: "july");
            //Console.WriteLine(blogs.Result);

            var collectionRequest = new CollectionRequest(settings);
            Task<Base<QueryCollection>> collections;

            //collections = collectionRequest.QueryCollections(contains: "phish");
            //Console.WriteLine(collections.Result);

            var singleCollectionRequest = new SingleCollectionRequest(settings);
            Task<SingleDataBase<SingleCollection>> getCollections;
            //getCollections = singleCollectionRequest.Get(1294148902);
            //Console.WriteLine(getCollections.Result);

            var jamChartRequest = new JamChartRequest(settings);
            //var jamCharts = jamChartRequest.GetAll();
            //Console.WriteLine(jamCharts.Result);

            jamChartRequest = new JamChartRequest(settings);
            //var singleChart = jamChartRequest.GetSingle("8");
            //Console.WriteLine(singleChart.Result);

            var peopleRequest = new PeopleRequest(settings);
            //var people = peopleRequest.GetAll();
            //Console.WriteLine(people.Result);

            //var peopleTypes = peopleRequest.GetPeopleTypes();
            //Console.WriteLine(peopleTypes.Result);

            //var reviewRequest = new ReviewRequest(settings);
            //var reviews = reviewRequest.QueryReviews(showid: 1605919636);
            //Console.WriteLine(reviews.Result);

            //var relRequest = new RelationshipRequest(settings);
            //var relations = relRequest.Get(751);
            //Console.WriteLine(relations.Result);

            //var showsRequest = new ShowLinksRequest(settings);
            //var shows = showsRequest.GetShowLinks(1569515741);
            //Console.WriteLine(shows.Result);

            //var showDataRequest = new ShowDataRequest(settings);
            //var shows = showDataRequest.GetUpcomingShows();
            //Console.WriteLine(shows.Result);

            //var showQueryRequest = new ShowQueryRequest(settings);
            //var shows = showQueryRequest.QueryShows(state: "ME");
            //Console.WriteLine(shows.Result);

            var venueRequest = new VenueRequest(settings);
            //var venue = venueRequest.Get(1);
            //Console.WriteLine(venue.Result);

            var venues = venueRequest.GetAll();
            Console.WriteLine(venues.Result);

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
