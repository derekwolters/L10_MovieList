using System;
using System.Collections.Generic;

///-----------------------------------------------------------------------------
///   Namespace:    L10_MovieList
///   Description:  Input a number from a list of genres to get the movies that
///                 match that genre.
///   Author:       Derek Wolters                
///   Date:         4.10.17
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------------------

namespace L10_MovieList
{
    class MovieList
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            String userGenre = "";
            List<string> genreList = new List<string>();
            List<Movie> movies = new List<Movie>() {

            new Movie("Star Wars", "SciFi"),
            new Movie("Dune", "SciFi"),
            new Movie("Indiana Jones", "Adventure"),
            new Movie("Lord of the Rings", "Fantasy"),
            new Movie("Titanic", "Romance"),
            new Movie("The Lion King", "Children's"),
            new Movie("Step Dads", "Comedy"),
            new Movie("21 Jump Street", "Comedy"),
            new Movie("Men In Black", "SciFi"),
            new Movie("Hitchhiker's Guide to the Galaxy", "SciFi")
        };
            while (keepGoing)
            {
                Console.WriteLine("There are " + movies.Count 
                                    + " movies in this list.");
                Console.WriteLine("What genre are you interested in? Enter " +
                            "the number of the corresponding genre.");

                genreList = BuildGenreList(movies);

                OutputGenreList(genreList);

                userGenre = genreList[IntInputValidator.ValidateInput()-1];                

                OutputList(BuildMovieList(movies, userGenre));

                Exit.ExitProgram();
            }                 
        }

        public static List<string> BuildGenreList(List<Movie> movies)
        {
            List<string> genreList = new List<string>();

            foreach (Movie g in movies)
            {
                if (!genreList.Contains(g.getGenre()))
                {
                    genreList.Add(g.getGenre());
                }
            }

            return genreList;
        }

        public static void OutputGenreList(List<string> genreList)
        {
            foreach (string s in genreList)
            {
                Console.Write(genreList.IndexOf(s) + 1 + "     ");
                Console.WriteLine(s);
            }
        }

        public static List<string> BuildMovieList(List<Movie> movies, 
                                                    string userGenre)
        {
            List <string> sortedList = new List<string>();

            foreach (Movie m in movies)
            {
                if (m.getGenre() == userGenre)
                    sortedList.Add(m.getTitle());

                sortedList.Sort();
            }
            return sortedList;
        }

        public static void OutputList(List<string> List)
        {
            foreach (string s in List)
            {
                Console.WriteLine(s);
            }
        }
    }
}
