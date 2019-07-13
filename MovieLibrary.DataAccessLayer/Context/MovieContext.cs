using Microsoft.EntityFrameworkCore;
using MovieLibrary.DomainModel;

namespace MovieLibrary.DataAccessLayer.Context
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}