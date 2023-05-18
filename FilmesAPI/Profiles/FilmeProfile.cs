using AutoMapper;
using FilmesAPI.Data.DTO;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, FilmeViewModel>();
        CreateMap<UpdateFilmeDto, FilmeViewModel>();
        CreateMap<FilmeViewModel, UpdateFilmeDto>();
        CreateMap<FilmeViewModel, ReadFilmeDto>()
            .ForMember(filmeDto => filmeDto.Sessoes,
                opt => opt.MapFrom(filme => filme.Sessoes));
    }
}
