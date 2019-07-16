using MovieLibrary.DomainModel;
using MovieLibrary.DtoContracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieLibrary.DataAccessLayer.Repository.Abstractions
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();

        Task<Movie> GetMovieByIdAsync(Guid movieId);

        Task SaveMovie(MovieDto movieDto);
    }
}
