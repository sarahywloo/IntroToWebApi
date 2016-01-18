using IntroToWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroToWebApi.Controllers
{
    public class MoviesController : ApiController {

        //Static properties exist on the class itself, will exist across controllers for now, NOT for actual production use.
        public static IList<Movie> _movies = new List<Movie>() {
            new Movie() {
                Id = 0,
                Title = "Star Trek"
            }
        };

        //GET: /api/movies/5
        public Movie Get(int id) {
            return _movies.First(x => x.Id == id);
            //return _movies[id];
            //return new Movie() {
            //    Id = id,
            //    Title = "Star Wars"
            //};
        }

        //POST:
        //returns a status quo instead of void
        public IHttpActionResult Post(Movie newMovie) {
            _movies.Add(newMovie);
            return Ok(); 
        }

        public IHttpActionResult Post(MovieBattle battle) {
            return Ok();
        }

        public IHttpActionResult Post(int id, Movie changes) {
            var dbMovie = _movies.First(x => x.Id == id);
            dbMovie.Id = changes.Id;
            dbMovie.Title = changes.Title;
            dbMovie.Genre = changes.Genre;
            dbMovie.ReleaseDate = changes.ReleaseDate;
            return Ok();
        }
    }
}
