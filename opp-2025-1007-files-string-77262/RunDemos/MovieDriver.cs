using opp_2025_1007_files_string_77262.Models;
using opp_2025_1007_files_string_77262.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_2025_1007_files_string_77262.RunDemos
{
    public static class MovieDriver
    {
        public static void Run()
        {
            Console.WriteLine("MovieDriver.Run() called");
            ShowMovieData();
        }

        public static void ShowMovieData()
        {

            List<Movie> movies = MovieRepository.GetAllMovies();
            // Display the list of movies
            Console.WriteLine("=== Movie List ===\n");
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie.ToString());
            }
        }

    }
}
