using System;

///-----------------------------------------------------------------------------
///   Namespace:    L3_SquaresAndCubes
///   Description:  Input a number to get the square and cube of it
///   Author:       Derek Wolters                
///   Date:         3.29.17
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------------------
///
namespace L10_MovieList
{
    class Movie
    {
        private string title;
        private string genre;

        public Movie(string title, string genre)
        {
            this.title = title;
            this.genre = genre;
        }

        public string setGenre(string genre)
        {
            return genre;
        }

        public string setTitle(string title)
        {
            return title;
        }

        public string getGenre(string title)
        {
            return genre;
        }

        public string getGenre()
        {
            return this.genre;
        }

        public string getTitle(string genre)
        {
            return title;
        }

        public void printTitle(string genre)
        {
            Console.WriteLine(title);
        }

        public void printGenre()
        {
            Console.WriteLine(this.genre);
        }
    }
}
