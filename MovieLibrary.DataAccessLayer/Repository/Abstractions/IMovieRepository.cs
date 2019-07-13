using MovieLibrary.DomainModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieLibrary.DataAccessLayer.Repository.Abstractions
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();

        Task<IEnumerable<Movie>> GetMovieByIdAsync(int movieId);
    }
}
