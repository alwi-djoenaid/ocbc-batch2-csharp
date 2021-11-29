using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Assignment10.Models;

namespace Assignment10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController: ControllerBase
    {
        private MovieContext _context;

        public MovieController(MovieContext context)
        {
            this._context = context;
        }

        [HttpGet(Name = "GetAllMovies")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            var movie = _context.getAllMovie();

            if (movie.Count != 0)
            {
                return new OkObjectResult(new { Success = true, movie });
            }

            return BadRequest("Failed to get movie details");
        }

        [HttpGet("{id}", Name = "GetMovieById")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieById(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            var movie = _context.getMovieById(id);

            if(movie.Count == 1)
            {
                return new OkObjectResult(new { Success = true, movie });
            }

            return BadRequest("Failed to get movie details");
        }

        [HttpPost(Name = "InsertMovie")]
        public ActionResult<IEnumerable<MovieItem>> InsertMovie(MovieItem movie)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return  _context.InsertMovie(movie);
        }

        [HttpPut("{id}", Name = "UpdateMovie")]
        public ActionResult<IEnumerable<MovieItem>> Update(int id, MovieItem movie)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.UpdateMovie(id, movie);
        }

        [HttpDelete("{id}", Name = "DeleteMovie")]
        public ActionResult<IEnumerable<MovieItem>> DeleteMovie(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;

            if (_context.DeleteMovie(id))
            {
                return Ok("Delete Success!");
            }

            return NotFound("Failed to delete movie");
        }
    }
}
