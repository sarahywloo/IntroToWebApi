using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroToWebApi.Models {
    public class Movie {

        //every model should have an Id! to be used in databases.
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

        public DateTime ReleaseDate { get; set; }

        //Adding a list of type Actor into our movie class
        public List<Actor> Actors { get; set; }
    }
}