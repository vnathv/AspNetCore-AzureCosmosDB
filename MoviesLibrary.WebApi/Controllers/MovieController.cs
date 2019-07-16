using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieLibrary.ClientContract;
using MovieLibrary.DtoContracts;
using MovieLibrary.Provider.Abstractions;

namespace MoviesLibrary.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieProvider movieProvider;

        public MovieController(IMovieProvider movieProvider)
        {
            this.movieProvider = movieProvider;
        }

        // POST api/movie
        [HttpPost]
        public IActionResult SaveMovie([FromBody] Movie movie)
        {
            var movieDto = Mapper.Map<Movie, MovieDto>(movie);

            movieProvider.SaveMovie(movieDto);

            return CreatedAtAction(nameof(SaveMovie),null);

        }
    }
}