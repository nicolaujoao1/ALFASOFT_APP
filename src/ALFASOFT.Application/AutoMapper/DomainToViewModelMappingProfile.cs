using AutoMapper;

using ALFASOFT.Domain.Entities;
using ALFASOFT.Application.DTOs;

namespace ALFASOFT.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Contact, ContactDTO>();
        }
        
    }
}
