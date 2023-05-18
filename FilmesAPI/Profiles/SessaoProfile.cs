using AutoMapper;
using FilmesAPI.Data.DTO;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, SessaoViewModel>();
            CreateMap<SessaoViewModel, ReadSessaoDto>();
        }
       
    }
}
