using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/movies
        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }

        // GET /api/movies/id
        public Movie GetMovies(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return movie;
        }

        //POST /api/movies
        [HttpPost]
        public Movie CreateMovie(Movie movie)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            return movie;
        }

        //PUT /api/movies
        [HttpPut]
        public void UpdateMovie(int id, Movie movie)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            movieInDb.Name = movie.Name;
            movieInDb.ReleaseDate = movie.ReleaseDate;
            movieInDb.DateAdded = movie.DateAdded;
            movie.Stock = movie.Stock;
            movie.GenreId = movie.GenreId;

            _context.SaveChanges();
        }

        //PUT /api/movies
        [HttpDelete]
        public void DeleteMovie(int id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();
        }

    }
}
