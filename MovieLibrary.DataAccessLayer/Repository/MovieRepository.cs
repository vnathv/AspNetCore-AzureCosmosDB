using Microsoft.EntityFrameworkCore;
using MovieLibrary.DataAccessLayer.Context;
using MovieLibrary.DataAccessLayer.Repository.Abstractions;
using MovieLibrary.DomainModel;
using MovieLibrary.DtoContracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace MovieLibrary.DataAccessLayer.Repository
{
    public class MovieRepository : IMovieRepository, IDisposable
    {
        private readonly MovieContext movieContext;

        public MovieRepository(MovieContext movieContext)
        {
            this.movieContext = movieContext;
        }


        public async Task<Movie> GetMovieByIdAsync(Guid movieId)
        {
            return await movieContext.Movies
                 .Include(a => a.Director)
                .Include(a => a.Producer)
                .FirstOrDefaultAsync(a => a.MovieId == movieId);
        }

        public async Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            return await movieContext.Movies
                .Include(a => a.Director)
                .Include(a => a.Producer)
                .ToListAsync();
              
        }

        public async Task SaveMovie(MovieDto movieDto)
        {
            try
            {
                var movie = Mapper.Map<MovieDto, Movie>(movieDto);

                movieContext.Movies.Add(movie);
                 movieContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(movieContext != null)
                {
                    movieContext.Dispose();
                }
            }
        }
        
    }
}
