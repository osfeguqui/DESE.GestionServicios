using AutoMapper;
using DESE.Application.Dtos;
using DESE.Domain.Entities;

namespace DESE.Application.Mappings
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile() 
        {
            CreateMap<Cliente, ClienteDto>();
        }
    }
}
