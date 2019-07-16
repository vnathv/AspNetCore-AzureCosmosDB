using MovieLibrary.DomainModel;
using MovieLibrary.DtoContracts;

namespace MovieLibrary.Provider.Abstractions
{
    public interface IMovieProvider
    {
        void SaveMovie(MovieDto movie);
    }
}