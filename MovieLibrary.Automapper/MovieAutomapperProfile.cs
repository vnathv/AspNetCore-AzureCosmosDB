using AutoMapper;
using MovieLibrary.DomainModel;
using MovieLibrary.DtoContracts;
using System;
using System.Collections.Generic;
using System.Text;
using ClientContract = MovieLibrary.ClientContract;

namespace MovieLibrary.Automapper
{
    public class MovieAutomapperProfile : Profile
    {
        public MovieAutomapperProfile()
        {
            CreateMap<MovieDto, Movie>().ReverseMap();
            CreateMap<DirectorDto, Director>().ReverseMap();
            CreateMap<ProducerDto, Producer>().ReverseMap();

            CreateMap<ClientContract.Movie, MovieDto>().ReverseMap();
        }
    }
}
