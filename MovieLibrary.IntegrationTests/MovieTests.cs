using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieLibrary.DataAccessLayer.Context;
using MovieLibrary.DataAccessLayer.Repository;
using MovieLibrary.DtoContracts;
using MovieLibrary.Provider;
using MovieLibrary.Provider.Abstractions;
using FizzWare.NBuilder;
using AutoMapper;
using MovieLibrary.Automapper;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace MovieLibrary.IntegrationTests
{
    [TestClass]
    public class MovieTests
    {
        [TestInitialize]
        public void Setup()
        {
            Mapper.Reset();
            Mapper.Initialize(cfg => cfg.AddProfile<MovieAutomapperProfile>());
        }


        [TestMethod]
        public void SaveMovie()
        {
            //Arrange
            var configuration = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json").Build();

            var options = new DbContextOptionsBuilder<MovieContext>()
                .UseCosmos(configuration["CosmosDBSetting:DbUri"], configuration["CosmosDBSetting:PrimaryKey"], "MovieDB")
                .Options;


            IMovieProvider movieProvider = new MovieProvider(new MovieRepository(new MovieContext(options)));

            var director = Builder<DirectorDto>.CreateNew().Build();
            var producer = Builder<ProducerDto>.CreateNew().Build();

            var movie = Builder<MovieDto>.CreateNew().Build();
            movie.Director = director;
            movie.Producer = producer;

            //Act
            movieProvider.SaveMovie(movie);

            //Assert
        }
    }
}
