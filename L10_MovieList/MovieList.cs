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
            List<Movie> movies = new List<Movie>();
            bool keepGoing = true;
            String userGenre = "";
            List<string> genreList = new List<string>();

            movies.Add(new Movie("Star Wars", "SciFi"));
            movies.Add(new Movie("Dune", "SciFi"));
            movies.Add(new Movie("Indiana Jones", "Adventure"));
            movies.Add(new Movie("Lord of the Rings", "Fantasy"));
            movies.Add(new Movie("Titanic", "Romance"));
            movies.Add(new Movie("The Lion King", "Children's"));
            movies.Add(new Movie("Step Dads", "Comedy"));
            movies.Add(new Movie("21 Jump Street", "Comedy"));
            movies.Add(new Movie("Men In Black", "SciFi"));
            movies.Add(new Movie("Hitchhiker's Guide to the Galaxy", "SciFi"));            

            while (keepGoing)
            {
                Console.WriteLine("There are " + movies.Count 
                                    + " movies in this list.");
                Console.WriteLine("What genre are you interested in? Enter " +
                            "the number of the corresponding genre.");

                genreList = BuildGenreList(movies);

                OutputGenreList(genreList);

                userGenre = genreList[IntInputValidator.ValidateInput()-1];

                foreach(Movie m in movies)
                {
                    if (m.getGenre() == userGenre)
                        m.printTitle(userGenre);
                }

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
    }
}
