using AutoMapper;
using FilmesAPI.Data.DTO;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;

public class EnderecoProfile : Profile
{
    public EnderecoProfile()
    {
        CreateMap<CreateEnderecoDto, EnderecoViewModel>();
        CreateMap<UpdateEnderecoDto, EnderecoViewModel>();
        CreateMap<EnderecoViewModel, UpdateEnderecoDto>();
        CreateMap<EnderecoViewModel, ReadEnderecoDto>();
    }
}
