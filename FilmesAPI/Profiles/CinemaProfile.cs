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
            CreateMap<CinemaViewModel, ReadCinemaDto>()
                //Este filtro indica que o campo ReadEnderecoDto presente em ReadCinemaDto será 
                //mapeado o campo Endereco de CinemaViewModel
                .ForMember(cinemaDto => cinemaDto.Endereco,
                opt => opt.MapFrom(cinema => cinema.Endereco)).
                ForMember(cinemaDto => cinemaDto.Sessoes,
                opt => opt.MapFrom(cinema => cinema.Sessoes));
            CreateMap<CinemaViewModel, UpdateCinemaDto>();
        }
    }
}
