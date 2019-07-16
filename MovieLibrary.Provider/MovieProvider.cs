using MovieLibrary.DataAccessLayer.Repository.Abstractions;
using MovieLibrary.DomainModel;
using MovieLibrary.DtoContracts;
using MovieLibrary.Provider.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary.Provider
{
    public class MovieProvider : IMovieProvider
    {
        private readonly IMovieRepository movieRepository;

        public MovieProvider(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }
        public void SaveMovie(MovieDto movie)
        {
            movieRepository.SaveMovie(movie);
        }
    }
}
