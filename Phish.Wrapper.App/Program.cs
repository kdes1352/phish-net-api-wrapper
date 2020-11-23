﻿using System;

namespace Phish.Wrapper.App
{
    using System.IO;
    using System.Threading.Tasks;
    using Core;
    using Core.Artists;
    using Core.Setlists;
    using Microsoft.Extensions.Configuration;
    using Models;
    using Models.Artists;
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
            Console.WriteLine(artists.Result);

            //Console.WriteLine(show.Result);
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
