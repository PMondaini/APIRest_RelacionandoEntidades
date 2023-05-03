using AutoMapper;
using FilmesAPI.Data.DTO;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, CinemaViewModel>();
            CreateMap<CinemaViewModel, ReadCinemaDto>();
            CreateMap<CinemaViewModel, UpdateCinemaDto>();
        }
    }
}
