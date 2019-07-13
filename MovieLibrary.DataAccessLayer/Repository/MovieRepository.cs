using Microsoft.EntityFrameworkCore;
using MovieLibrary.DataAccessLayer.Context;
using MovieLibrary.DataAccessLayer.Repository.Abstractions;
using MovieLibrary.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.DataAccessLayer.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext movieContext;

        public MovieRepository(MovieContext movieContext)
        {
            this.movieContext = movieContext;
        }
        public async Task<IEnumerable<Movie>> GetMovieByIdAsync(int movieId)
        {
            return await movieContext.Movies.ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
