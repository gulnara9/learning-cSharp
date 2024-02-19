using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;

        }
        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "a" || value == "b" || value == "c" || value=="d")
                {
                    rating = value;
                }
                else
                {
                    rating = "d";
                }

            }
        }

    }
}
