using ALFASOFT.Application.DTOs;
using ALFASOFT.Domain.Entities;
using AutoMapper;

namespace ALFASOFT.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ContactDTO, Contact>()
               .ConstructUsing(c => new Contact(c.Name, c.ContactNumber, c.EmailAddress));
        }
    }
}
